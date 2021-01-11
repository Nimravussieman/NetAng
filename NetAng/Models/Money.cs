using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetAng.Models
{
    public class Money
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
