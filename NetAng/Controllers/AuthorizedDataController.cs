using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using NetAng.Models;
using NetAng.Models.SupportingModels;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NetAng.Controllers
{
    [ApiController]
    [Route("authorize")]
    //[Authorize]
    public class AuthorizedDataController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _claimsFactory;
        
        private AuthDbContext db;
        public AuthorizedDataController(AuthDbContext authDbContext, UserManager<ApplicationUser> userManager, IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory, ILogger<WeatherForecastController> logger)
        {
            this.db = authDbContext;
            _userManager = userManager;
            _claimsFactory = claimsFactory;
            _logger = logger;
           // ApUser = GetUserAsync();private ValueTask<ApplicationUser> ApUser;
        }//[FromBody]CRM_Lead Lead



        [HttpGet("getAuthAccountContactsPaginations")]
        public async Task<Object> AccountContactPaginationsAsync(string searchString, int? pageNumber, int pageSize/*,string searchBase, string searchField*/)
        {
            ApplicationUser user =await GetUserAsync();//.Result;
            this.db.Users.Include(u => u.Account.Contacts).First(u => u == user);
            var cont = user.Account.Contacts.AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
                cont.Where(c => c.Name.FirstName.Contains(searchString)|| c.Name.LastName.Contains(searchString)|| c.Name.SurName.Contains(searchString));
            return await PaginatedList<Contact>.CreateAsync(cont.AsNoTracking(), pageNumber ?? 1, pageSize);
        }
        [HttpPost("saveAuthAccountContact")]
        //public object SaveContact([FromBody] dynamic data)//
         //public object SaveContact([FromBody] Contact contact)
        //public async Task SaveContact()
        public  Object SaveContact([FromBody] System.Text.Json.JsonElement entity)//[FromBody]Newtonsoft.Json.Linq.JObject value
        {
            try
            {
                ApplicationUser user = GetUserAsync().Result;
                this.db.Users.Include(u => u.Account.Contacts).First(u => u == user);
                


                //var huy = value.for

                var p = entity.GetProperty("params");
                var idv = p.GetProperty("id");
                int id = idv.GetInt32();
                Contact contact;
                if (id != 0) contact = user.Account.Contacts.FirstOrDefault(c => c.Id == id) ;
                else contact = new Contact();


                var photov = p.GetProperty("photo");
                var namev = photov.GetProperty("name");
                var imageDatav = photov.GetProperty("imageData");
                string imageData = imageDatav.GetString();
                Image image;
                if (!String.IsNullOrEmpty(imageData))
                {
                    image = new Image() { Name = namev.GetString(), ImageData = imageData };
                    db.Images.Add(image);
                    contact.Photo = image;
                }
                

                var dateOfBirthv = p.GetProperty("dateOfBirth");
                DateTime.TryParse(dateOfBirthv.GetString(), out var parsedDateValue);

                // Объединяем полученные значения в один объект DateTime
                DateTime fullDateTime = new DateTime(parsedDateValue.Year,
                                parsedDateValue.Month,
                                parsedDateValue.Day);
                contact.DateOfBirth = fullDateTime;

                string position = p.GetProperty("position").GetString();
                if (!String.IsNullOrEmpty(position)) contact.Position = position;

                var phonesv = p.GetProperty("phones").EnumerateArray();
                foreach (var res in phonesv)
                {
                    var obj = res.EnumerateObject();
                    if (obj.GetType() == null) continue;///??????????????????????????????????????????????????????????????????????????????
                    Phone item = new Phone();
                    foreach (var prop in obj)
                    {
                        if (prop.Value.GetString() == "") continue;///???????????????????????????????????????????????????????????????????????
                        PropertyInfo propertyInfo = item.GetType().GetProperty(prop.Name, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                        if (propertyInfo.PropertyType==typeof(string))
                        {
                            propertyInfo.SetValue(item, Convert.ChangeType(prop.Value.GetString(), propertyInfo.PropertyType), null);
                        }
                        else if(propertyInfo.PropertyType == typeof(bool))
                        {
                            propertyInfo.SetValue(item, Convert.ChangeType(prop.Value.GetBoolean(), propertyInfo.PropertyType), null);
                        }
                        else if (propertyInfo.PropertyType == typeof(int))
                        {
                            int i = 0;
                            try { i = prop.Value.GetInt32(); } catch (Exception) { }
                            propertyInfo.SetValue(item, Convert.ChangeType(i, propertyInfo.PropertyType), null);
                        }
                    }
                    if (item.Id != 0)
                    {
                        db.Phones.Remove( db.Phones.FirstOrDefault(p => p.Id == item.Id));
                       // db.Phones.Remove(await db.Phones.FirstOrDefaultAsync(p => p.Id == item.Id));
                    }
                    db.Phones.Add(item);
                    contact.Phones.Add(item);
                }
                var emailsv = p.GetProperty("emails");
                var sitesv = p.GetProperty("sites");
                var messangerUrls = p.GetProperty("messangerUrls");
                var addresses = p.GetProperty("addresses");

                string contactType = p.GetProperty("contactType").GetString();
                if (!String.IsNullOrEmpty(contactType)) contact.Type = contactType;

                string contactSource = p.GetProperty("contactSource").GetString();
                if (!String.IsNullOrEmpty(contactSource)) contact.Source = contactSource;

                string description = p.GetProperty("description").GetString();
                if (!String.IsNullOrEmpty(description)) contact.Description = description;


                var Name = p.GetProperty("name");
                string first = Name.GetProperty("firstName").GetString(); if (!String.IsNullOrEmpty(first))contact.Name.FirstName = first;
                string last = Name.GetProperty("lastName").GetString(); if (!String.IsNullOrEmpty(last)) contact.Name.LastName = last;
                string sur =Name.GetProperty("surName").GetString(); if (!String.IsNullOrEmpty(sur)) contact.Name.SurName = sur;

                var permissionsv = p.GetProperty("permissions").EnumerateObject();//.Select(i=>i.Value);
                ContactFieldsPermissions per = new ContactFieldsPermissions();
                foreach (var prop in permissionsv)
                {
                    PropertyInfo propertyInfo = per.GetType().GetProperty(prop.Name, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    propertyInfo.SetValue(per, Convert.ChangeType(prop.Value.GetBoolean(), propertyInfo.PropertyType), null);
                }
                contact.Permissions = per;
                db.Contacts.Add(contact);
                db.SaveChanges();

                //Dictionary<string, string> dict = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(.);
                //string id;
                //dict.TryGetValue("id",out id);

                //var y = data.getType().GetProperty("id").GetValue(data, null);
                //var x = data.getType().GetProperty("name").GetValue(data, null);


                 return new { data = true };
            }
            catch (Exception ex)
            {
               return new { data = false };
            }
        }
        void addArr(System.Text.Json.JsonElement element,string propertyName)
        {

        }


        //[HttpGet("companyPaginations")]
        //public async Task<Object> CompanyPaginationsAsync(string searchString, int? pageNumber, int pageSize)

        [HttpGet("getLogo")]
        public object GetLogo()
        {
            //var q = this.db.Users.Include(u => u.Account).First(u => u.Id == user.Id);
            ApplicationUser user = GetUserAsync().Result;
            this.db.Users.Include(u => u.Account).First(u => u == user);
            string res = user?.Account?.Name ?? "";
            return new { data = res };
        }
        [HttpGet("getAcc")]
        public object GetAccAsync()
        {
            //var q = this.db.Users.Include(u => u.Account).First(u => u.Id == user.Id);
            ApplicationUser user = GetUserAsync().Result;
            this.db.Users.Include(u => u.Account.Permissions).First(u => u == user);
            //this.db.Entry(user).Collection(u => u.Account).Load();
            //this.db.Entry(user).Collection(u => u.Account.Projects).Load();
            //this.db.Entry(user).Collection(u => u.Account.Addresses).Load();
            return new { data = new { Permissions = user.Account.Permissions, Description = user.Account.Description, Name = user.Account.Name } };
        }

        [HttpGet("getProfile")]
        public object getProfile()
        {
            try
            {
                ApplicationUser user = GetUserAsync().Result;
                Account account = this.db.Users.Include(u => u.Account).First(u => u == user).Account;
                AccountCompanyFieldsPermissions permissions = account.Permissions;
                int addreses = account.Addresses.Count();
                int bankDetails = account.BankDetails.Count();
                int booleanFields = account.BooleanFields.Count();
                int companies = account.Companies.Count();
                int contacts = account.Contacts.Count();
                string currencyName = account.Currency.Name;
                Currency[] currencies = this.db.Currencies.ToArray();
                int dateTimeFields = account.DateTimeFields.Count();
                string description = account.Description;
                int details = account.Details.Count();
                int emails = account.Emails.Count();
                int employees = account.Employees.Count();
                int fieldOfActivities = account.FieldOfActivities.Count();
                int fileFields = account.FileFields.Count();
                int imageFields = account.ImageFields.Count();
                string imageLogo = account.ImageLogo.ImageData;
                int jobs = account.Jobs.Count();
                int messangerUrls = account.MessangerUrls.Count();
                string name = account.Name;
                int numericFields = account.NumericFields.Count();
                int operations = account.Operations.Count();
                int phones = account.Phones.Count();
                int products = account.Products.Count();
                int projects = account.Projects.Count();
                int stringFields = account.StringFields.Count();
               // int urlsFields = account.UrlsFields.Count();
                return new
                {
                    permissions = permissions,
                    addreses = addreses,
                    bankDetails = bankDetails,
                    booleanFields = booleanFields,
                    companies = companies,
                    contacts = contacts,
                    currencyName = currencyName,
                    currencies = currencies,
                    dateTimeFields = dateTimeFields,
                    description = description,
                    details = details,
                    emails = emails,
                    employees = employees,
                    fieldOfActivities = fieldOfActivities,
                    fileFields = fileFields,
                    imageFields = imageFields,
                    jobs = jobs,
                    messangerUrls = messangerUrls,
                    name = name,
                    numericFields = numericFields,
                    operations = operations,
                    phones = phones,
                    products = products,
                    projects = projects,
                    stringFields = stringFields,
                    //urlsFields = urlsFields
                };

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpGet("getContactTemplate")]
        public object GetContactTemplate()
        {
            Contact contact = new Contact();
            ContactType[] contactTypes = this.db.ContactTypes.ToArray();
            ContactSource[] contactSources = this.db.ContactSources.ToArray();
            return new { contact = contact, contactType = contactTypes, contactSource = contactSources };
        }
        //[HttpGet("getContactTemplate")]
        //public object GetContactTemplate()
        //{
        //    Contact contact = new Contact();
        //    ContactType[] contactTypes = this.db.ContactTypes.ToArray();
        //    ContactSource[] contactSources = this.db.ContactSources.ToArray();
        //    return new { contact = contact, contactType = contactTypes, contactSource = contactSources };
        //}


        private async ValueTask<ApplicationUser> GetUserAsync()
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var currentUserId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _userManager.FindByIdAsync(currentUserId);
        }


        [HttpGet("selects")]
        public object GetAccountType()
        {
            var AddressType = this.db.AddressTypes.ToArray();
            var CompanyType = this.db.CompanyTypes.ToArray();
            var ContactType = this.db.ContactTypes.ToArray();
            var DetailsType = this.db.DetailsTypes.ToArray();
            var EmailType = this.db.EmailTypes.ToArray();
            var NotificationType = this.db.NotificationTypes.ToArray();
            var OperationType = this.db.OperationTypes.ToArray();
            var PhoneType = this.db.PhoneTypes.ToArray();
            var UrlType = this.db.UrlTypes.ToArray();
            var MessangerUrlType = this.db.MessangerUrlTypes.ToArray();
            var ContactSources = this.db.ContactSources.ToArray();

            return new { AddressType = AddressType, CompanyType = CompanyType, ContactType = ContactType, DetailsType = DetailsType, EmailType = EmailType, NotificationType = NotificationType, OperationType = OperationType, PhoneType = PhoneType, UrlType = UrlType, MessangerUrlType = MessangerUrlType, ContactSources= ContactSources };
        }
        [HttpGet("getNewAccountContact")]
        public object GetNewAccountContact(string contactFrom, int? id)
        {
            //try
            //{
            //    ApplicationUser user = GetUserAsync().Result;
            //    this.db.Users.Include(u => u.Account.Permissions).Include(u=>u.Account.Contacts).Include(u=>u.Account.Companies).Include(u => u.Account.Operations).First(u => u == user);//.Permissions
            //    Contact contact = new Contact();
            //    user.Account.Contacts.Add(contact);
            //    if (contactFrom == "Company" && id != null) user.Account.Companies.FirstOrDefault(c => c.Id == id)?.Contacts.Add(contact);
            //    else if (contactFrom == "Operation" && id != null) user.Account.Operations.FirstOrDefault(c => c.Id == id)?.Contacts.Add(contact);
            //    //this.db.SaveChanges();
            //    return new { data = contact };
            //}
            //catch (Exception ex)
            //{
            return new { data = new Contact() {Name=new UserName() {FirstName="first",LastName="last",SurName="sur" } } };
            //}
        }

        [HttpPost]
        public object InitializeAction([FromBody] dynamic jsonData)
        {
            dynamic data = JsonConvert.DeserializeObject<dynamic>(jsonData.ToString());
            return data;
        }
        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;
            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);
            return str.ToUpper();
        }
        public static async Task<string> GetAccountAsync(Stream body)
        {
            using (StreamReader reader = new StreamReader(body, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }

    }
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => input.First().ToString().ToUpper() + input.Substring(1)
            };
    }
}
