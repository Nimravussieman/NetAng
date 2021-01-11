using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Services
{
    public class AuthMessageSenderOptions   //  send massage confirmation
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}
