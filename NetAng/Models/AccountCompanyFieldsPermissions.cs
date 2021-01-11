using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class AccountCompanyFieldsPermissions
    {
        [Key]
        public int Id { get; set; }
        public bool IsPublic { get; set; }
        public bool CurrencyIsPublic { get; set; }
        public bool CurrencyIsVisible { get; set; }
        public bool ProductsIsPublic { get; set; }
        public bool ProductssVisible { get; set; }
        public bool ProjectsIsPublic { get; set; }
        public bool ProjectssVisible { get; set; }
        public bool JobsIsPublic { get; set; }
        public bool JobssVisible { get; set; }
        public bool CompaniesIsPublic { get; set; }
        public bool CompaniessVisible { get; set; }
        public bool ImageLogoIsPublic { get; set; }
        public bool ImageLogosVisible { get; set; }
        public bool FieldOfActivitiesIsPublic { get; set; }
        public bool FieldOfActivitiessVisible { get; set; }
        public bool PhonesIsPublic { get; set; }
        public bool PhonessVisible { get; set; }
        public bool EmailsIsPublic { get; set; }
        public bool EmailssVisible { get; set; }
        public bool SitesIsPublic { get; set; }
        public bool SitessVisible { get; set; }
        public bool MessangerUrlsIsPublic { get; set; }
        public bool MessangerUrlssVisible { get; set; }
        public bool ContactsIsPublic { get; set; }
        public bool ContactssVisible { get; set; }
        public bool AddressesIsPublic { get; set; }
        public bool AddressessVisible { get; set; }
        public bool EmployeesIsPublic { get; set; }
        public bool EmployeessVisible { get; set; }
        public bool DetailsIsPublic { get; set; }
        public bool DetailssVisible { get; set; }
        public bool BankDetailsIsPublic { get; set; }
        public bool BankDetailssVisible { get; set; }
        public bool DescriptionIsPublic { get; set; }
        public bool DescriptionsVisible { get; set; }
        public bool StringFieldsIsPublic { get; set; }
        public bool StringFieldssVisible { get; set; }
        public bool NumericFieldsIsPublic { get; set; }
        public bool NumericFieldssVisible { get; set; }
        public bool DateTimeFieldsIsPublic { get; set; }
        public bool DateTimeFieldssVisible { get; set; }
        public bool UrlsFieldsIsPublic { get; set; }
        public bool UrlsFieldssVisible { get; set; }
        public bool FileFieldsIsPublic { get; set; }
        public bool FileFieldssVisible { get; set; }
        public bool ImageFieldsIsPublic { get; set; }
        public bool ImageFieldssVisible { get; set; }
        public bool BooleanFieldsIsPublic { get; set; }
        public bool BooleanFieldssVisible { get; set; }
        public bool OperationsIsPublic { get; set; }
        public bool OperationssVisible { get; set; }
        public bool PermissionsIsPublic { get; set; }
        public bool PermissionssVisible { get; set; }

    }
}
