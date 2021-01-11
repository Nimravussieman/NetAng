using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class ContactFieldsPermissions
    {
        [Key]
        public int Id { get; set; }
        public bool IsPublic { get; set; }
        public bool PhotoIsPublic { get; set; }
        public bool DateOfBirthIsPublic { get; set; }
        public bool PositionIsPublic { get; set; }
        public bool PhonesIsPublic { get; set; }
        public bool EmailsIsPublic { get; set; }
        public bool SitesIsPublic { get; set; }
        public bool MessangerUrlsIsPublic { get; set; }
        public bool CompaniesIsPublic { get; set; }
        public bool AddressesIsPublic { get; set; }
        public bool DetailsIsPublic { get; set; }
        public bool ContactTypeIsPublic { get; set; }
        public bool ContactSourceIsPublic { get; set; }
        public bool DescriptionIsPublic { get; set; }
    }
}
