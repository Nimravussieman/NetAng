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
        [DataType(DataType.Url)]
        public string Value { get; set; }
        public UrlType UrlType { get; set; }
    }
}
//public class Url
//{       
        //[Key]
        //public int Id { get; set; }
        //public Uri Link { get; set; }

//}