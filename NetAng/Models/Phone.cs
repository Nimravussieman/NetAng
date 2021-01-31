using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        [Phone]
        //[Required(ErrorMessage = "You must provide a phone number")]
        //[Display(Name = "Home Phone")]
        //[DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public string Value { get; set; }
        public string Type { get; set; }
    }
}
