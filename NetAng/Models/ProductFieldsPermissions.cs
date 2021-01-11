using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class ProductFieldsPermissions
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        public bool NameIsPublic { get; set; }
        public bool DescriptionIsPublic { get; set; }
        public bool ImagesIsPublic { get; set; }
        public bool PriceIsPublic { get; set; }
        public bool QuantityIsPublic { get; set; }
        public bool MeasurementUnitIsPublic { get; set; }
        public bool CreateDateIsPublic { get; set; }
        public bool DateOfChangeIsPublic { get; set; }
        public bool StartActivityDateIsPublic { get; set; }
        public bool StopActivityDateIsPublic { get; set; }
        public bool SortIndexIsPublic { get; set; }
        public bool StringFieldsIsPublic { get; set; }
        public bool NumericFieldsIsPublic { get; set; }
        public bool DateTimeFieldsIsPublic { get; set; }
        public bool UrlsFieldsIsPublic { get; set; }
        public bool FileFieldsIsPublic { get; set; }
        public bool PermissionsIsPublic { get; set; }

    }
}
