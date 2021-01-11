using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
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
        public int Priority { get; set; }
        public string Goals { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSuccessfully { get; set; }

    }
}
