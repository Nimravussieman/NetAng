using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class OperationFieldsPermissions
    {
        [Key]
        public int Id { get; set; }
        public bool IsPublic { get; set; }
        public bool Amount { get; set; }
        public bool CreateDate { get; set; }
        public bool DateOfChange { get; set; }
        public bool EndDate { get; set; }
        public bool Phase { get; set; }
        public bool TypeOfOperation { get; set; }
        public bool Description { get; set; }
        public bool AvailableToEveryone { get; set; }
        public bool Contacts { get; set; }
        public bool Contractors { get; set; }
        public bool Permissions { get; set; }
    }
}
