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
        public UserName Name { get; set; }
        public Image Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }
        public List<Url> Sites { get; set; }
        public List<MessangerUrl> MessangerUrls { get; set; }
        public List<Company> RelatedCompanies { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Details> Details { get; set; }
        //public List<Note> Notes { get; set; }
        public ContactType ContactType { get; set; }
        public ContactSource ContactSource { get; set; }
        public string Description { get; set; }
        public ContactFieldsPermissions ContactFieldsPermissions { get; set; }
    }
}
