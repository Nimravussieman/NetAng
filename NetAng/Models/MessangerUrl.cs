using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class MessangerUrl
    {
        [Key]
        public int Id { get; set; }
        public Url Value { get; set; }
        public string Type { get; set; }
        //public MessangerUrlTypeOf MessangerUrlTypeOf { get; set; }
    }
}
//account membership