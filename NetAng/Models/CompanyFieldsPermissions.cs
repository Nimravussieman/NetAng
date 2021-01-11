using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class CompanyFieldsPermissions
    {
        [Key]
        public int Id { get; set; }
        public bool IsPublic { get; set; }
        public bool PhonesIsPublic { get; set; }
        public bool EmailsIsPublic { get; set; }
        public bool SitesIsPublic { get; set; }
        public bool MessangerUrlsIsPublic { get; set; }
        public bool ContactsIsPublic { get; set; }
        public bool AddressesIsPublic { get; set; }
        public bool EmployeesIsPublic { get; set; }
        public bool DetailsIsPublic { get; set; }
        public bool BankDetailsIsPublic { get; set; }
        public bool DescriptionIsPublic { get; set; }
        public bool StringFieldsIsPublic { get; set; }
        public bool NumericFieldsIsPublic { get; set; }
        public bool DateTimeFieldsIsPublic { get; set; }
        public bool UrlsFieldsIsPublic { get; set; }
        public bool FileFieldsIsPublic { get; set; }
        public bool PermissionsIsPublic { get; set; }
        public bool BooleanFieldsIsPublic { get; set; }
    }
}
