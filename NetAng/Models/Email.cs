using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Value { get; set; }
        public string Type { get; set; }
    }
}
