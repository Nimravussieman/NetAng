using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Image ImageLogo { get; set; }
        public string Type { get; set; }
        public List<string> FieldOfActivities { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }
        public List<Url> Sites { get; set; }
        public List<MessangerUrl> MessangerUrls { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Employe> Employees { get; set; }
        public List<Details> Details { get; set; }
       public List<BankDetails> BankDetails { get;set; }
        public string Description { get; set; }
        public List<StringField> StringFields { get; set; }
        public List<NumericField> NumericFields { get; set; }
        public List<DateTimeField> DateTimeFields { get; set; }
        //public List<Url> UrlsFields { get; set; }
        public List<FileField> FileFields { get; set; }
        public List<ImageField> ImageFields{ get; set; }
        public List<BooleanField> BooleanFields { get; set; }
        public CompanyFieldsPermissions Permissions { get; set; } = new CompanyFieldsPermissions() {
            IsPublic = true,
            MessangerUrls_IsPublic = true,
            NumericFields_IsPublic = false,
            Permissions_IsPublic = false,
            Phones_IsPublic = true,
            Sites_IsPublic = true,
            StringFields_IsPublic = false,
            //UrlsFields_IsPublic = false,
            Addresses_IsPublic = true,
            BankDetails_IsPublic = false,
            Description_IsPublic = true,
            Contacts_IsPublic = false,
            DateTimeFields_IsPublic = false,
            Details_IsPublic = false,
            Emails_IsPublic = true,
            Employees_IsPublic = false,
            FileFields_IsPublic = false,
            BooleanFields_IsPublic = false

        };
    }
}
