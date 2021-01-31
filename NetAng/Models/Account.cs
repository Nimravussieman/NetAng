using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetAng.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public string Name { get; set; }
        //public Company AccountCompany { get; set; }
        public Currency Currency { get; set; }
        public List<Product> Products { get; set; }
        public List<Project> Projects { get; set; }
        public List<Job> Jobs { get; set; }
        public List<Company> Companies { get; set; }
        public Image ImageLogo { get; set; }
        public List<string> FieldOfActivities { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }
        public Url Site { get; set; }
        public List<MessangerUrl> MessangerUrls { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Employe> Employees { get; set; }
        public List<Details> Details { get; set; }
        public List<BankDetails> BankDetails { get; set; }
        public string Description { get; set; }
        public List<StringField> StringFields { get; set; }
        public List<NumericField> NumericFields { get; set; }
        public List<DateTimeField> DateTimeFields { get; set; }
        //public List<Url> UrlsFields { get; set; }
        public List<FileField> FileFields { get; set; }
        public List<ImageField> ImageFields { get; set; }
        public List<BooleanField> BooleanFields { get; set; }
        public List<Operation> Operations { get; set; }
        public AccountCompanyFieldsPermissions Permissions { get; set; } = new AccountCompanyFieldsPermissions()
        {
            IsPublic = true,
            Currency_IsPublic = false,
            Currency_IsVisible = false,
            Products_IsPublic = false,
            Products_IsVisible = false,
            Projects_IsPublic = false,
            Projects_IsVisible = false,
            Jobs_IsPublic = false,
            Jobs_IsVisible = false,
            Companies_IsPublic = false,
            Companies_IsVisible = false,
            ImageLogo_IsPublic = false,
            ImageLogo_IsVisible = false,
            FieldOfActivities_IsPublic = false,
            FieldOfActivities_IsVisible = false,
            Phones_IsPublic = false,
            Phones_IsVisible = false,
            Emails_IsPublic = false,
            Emails_IsVisible = false,
            Sites_IsPublic = false,
            Sites_IsVisible = false,
            MessangerUrls_IsPublic = false,
            MessangerUrls_IsVisible = false,
            Contacts_IsPublic = false,
            Contacts_IsVisible = false,
            Addresses_IsPublic = false,
            Addresses_IsVisible = false,
            Employees_IsPublic = false,
            Employees_IsVisible = false,
            Details_IsPublic = false,
            Details_IsVisible = false,
            BankDetails_IsPublic = false,
            BankDetails_IsVisible = false,
            Description_IsPublic = false,
            Descriptions_IsVisible = false,
            StringFields_IsPublic = false,
            StringFields_IsVisible = false,
            NumericFields_IsPublic = false,
            NumericFields_IsVisible = false,
            DateTimeFields_IsPublic = false,
            DateTimeFields_IsVisible = false,
            //UrlsFields_IsPublic = false,
            //UrlsFields_IsVisible = false,
            FileFields_IsPublic = false,
            FileFields_IsVisible = false,
            ImageFields_IsPublic = false,
            ImageFields_IsVisible = false,
            BooleanFields_IsPublic = false,
            BooleanFields_IsVisible = false,
            Operations_IsPublic = false,
            Operations_IsVisible = false,
            Permissions_IsPublic = false,
            Permissions_IsVisible = false
        };

    }
}
