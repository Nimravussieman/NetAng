using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class ImageField
    {
        [Key]
        public int Id { get; set; }
        public Image File { get; set; }
        public string Description { get; set; }

    }
}
