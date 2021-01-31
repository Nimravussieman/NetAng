using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAng.Models.SupportingModels
{
    public class BinderHellper
    {
        public static async Task<string> GetAccountAsync(Stream body)
        {

            using (StreamReader reader = new StreamReader(body, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }

        }
    }
}
