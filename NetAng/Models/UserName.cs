using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class UserName
    {
        //[Key]
        //public int Id { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
    }
}
