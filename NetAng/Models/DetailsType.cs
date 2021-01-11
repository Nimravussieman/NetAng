using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class DetailsType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
//фізичну особу-підприємця       юридичну особу         відокремлений підрозділ юридичної особи
