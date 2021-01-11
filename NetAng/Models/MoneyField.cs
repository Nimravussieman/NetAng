using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class MoneyField
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Money Value { get; set; }
        public string Description { get; set; }
    }
}
