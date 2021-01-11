using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsAdmin { get; set; }
        public string DataEventRecordsRole { get; set; }
        public string SecuredFilesRole { get; set; }
        public Account Account
        {
            get { return this.account ?? new Account(); }//    ??  /   ??=
            set { this.account = value; }
        }
        private Account? account = null;
        public DateTime DateCreated
        {
            get { return this.createDate.HasValue ? this.createDate.Value : DateTime.Now; }
            set { this.createDate = value; }
        }
        private DateTime? createDate = null;

    }
}
