using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Url
    {
        [Key]
        public int Id { get; set; }
        //[DataType(DataType.Url)]
        public string Value { get; set; }
        public string Type { get; set; }
    }
}
