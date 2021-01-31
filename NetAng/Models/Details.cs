using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class Details
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// ////////////////////
        /// </summary>
        public string AbbreviatedNameOfTheOrganization { get; set; }//Скорочене найменування організації
        public int USREOU { get; set; }//ЄДРПОУ
        public string GeneralDirector { get; set; }
        public string ChiefAccountant { get; set; }

        /// <summary>
        /// ////////////////
        /// </summary>

        public string Name { get; set; }
        public string RNTRC { get; set; }//РНОКПП   //ДРФОПП    //Реєстраціний номер облікової картки платника податків    //десятизначний номер з Державного реєстру фізичних осіб

        /// <summary>
        /// ////////////////
        /// </summary>
        public int CertificateNumber { get; set; } //Номер свідоцтва платника ПДВ
        public int IPN { get; set; }//Індивідуальний податковий номер платника ПДВ / Individual tax number of the VAT payer
        public bool VATPayer { get; set; }//Платник ПДВ
        public List<Address> Addresses { get; set; }
        public List<BankDetails> BankDetails { get; set; }
    }
}
