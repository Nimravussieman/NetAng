using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]//????????????????????????????
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Image> Images { get; set; }
        public Money Price { get; set; }
        public decimal Quantity { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        //public DateTime CreateDate { get; set; }
        //public DateTime DateOfChange { get; set; }
        //public DateTime StartActivityDate { get; set; }
        //public DateTime StopActivityDate { get; set; }
        public DateTime DateCreated
        {
            get { return this.createDate.HasValue ? this.createDate.Value : DateTime.Now; }
            set { this.createDate = value; }
        }
        private DateTime? createDate = null;
        public DateTime DateOfChange
        {
            get { return this.dateOfChange.HasValue ? this.dateOfChange.Value : DateTime.Now; }
            set { this.dateOfChange = value; }
        }
        private DateTime? dateOfChange = null;
        public DateTime StartActivityDate
        {
            get { return this.startActivityDate.HasValue ? this.startActivityDate.Value : DateTime.Now; }
            set { this.startActivityDate = value; }
        }
        private DateTime? startActivityDate = null;
        public DateTime StopActivityDate
        {
            get { return this.stopActivityDate.HasValue ? this.stopActivityDate.Value : DateTime.MaxValue; }
            set { this.stopActivityDate = value; }
        }
        private DateTime? stopActivityDate = null;

        public int SortIndex { get; set; }

        public List<StringField> StringFields { get; set; }
        public List<NumericField> NumericFields { get; set; }
        public List<DateTimeField> DateTimeFields { get; set; }
        public List<Url> UrlsFields { get; set; }
        public List<FileField> FileFields { get; set; }
        public ProductFieldsPermissions Permissions { get; set; }


    }
}
