using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class DateTimeField
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Value
        {
            get { return this.value.HasValue ? this.value.Value : DateTime.Now; }
            set { this.value = value; }
        }
        private DateTime? value = null;

        public string Description { get; set; }
    }
}
