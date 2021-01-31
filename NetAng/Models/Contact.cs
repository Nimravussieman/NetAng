using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public UserName Name { get; set; } = new UserName();
        public Image Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public List<string> FieldOfActivities { get; set; }
        public List<Phone> Phones { get; set; } = new List<Phone>();
        public List<Email> Emails { get; set; }
        public List<Url> Sites { get; set; }
        public List<MessangerUrl> MessangerUrls { get; set; }
        public List<Company> RelatedCompanies { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Details> Details { get; set; }
        //public List<Note> Notes { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public ContactFieldsPermissions Permissions { get; set; } = new ContactFieldsPermissions()
        {
            IsPublic = false,
            Addresses_IsPublic = true,
            Companies_IsPublic = false,
            ContactSource_IsPublic = true,
            ContactType_IsPublic = true,
            DateOfBirth_IsPublic = true,
            Description_IsPublic = false,
            Details_IsPublic = false,
            Emails_IsPublic = true,
            MessangerUrls_IsPublic = true,
            Phones_IsPublic = true,
            Photo_IsPublic = true,
            Position_IsPublic = true,
            Sites_IsPublic = true

        };
    }
}
