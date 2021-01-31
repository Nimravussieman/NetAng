namespace NetAng.Models
{
    //[Microsoft.EntityFrameworkCore.Owned]
    public class ProductFieldsPermissions
    {
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        public bool Name_IsPublic { get; set; }
        public bool Description_IsPublic { get; set; }
        public bool Images_IsPublic { get; set; }
        public bool Price_IsPublic { get; set; }
        public bool Quantity_IsPublic { get; set; }
        public bool MeasurementUnit_IsPublic { get; set; }
        public bool CreateDate_IsPublic { get; set; }
        public bool DateOfChange_IsPublic { get; set; }
        public bool StartActivityDate_IsPublic { get; set; }
        public bool StopActivityDate_IsPublic { get; set; }
        public bool SortIndex_IsPublic { get; set; }
        public bool StringFields_IsPublic { get; set; }
        public bool NumericFields_IsPublic { get; set; }
        public bool DateTimeFields_IsPublic { get; set; }
        public bool UrlsFields_IsPublic { get; set; }
        public bool FileFields_IsPublic { get; set; }
        public bool Permissions_IsPublic { get; set; }

    }
}
