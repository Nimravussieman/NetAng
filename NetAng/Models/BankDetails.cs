using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class BankDetails
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameOfTheBank { get; set; }//Найменування банку
        public int MFO { get; set; } //МФО  // 6-значний код, який використовується для ідентифікації банківських установ в Україні.
        public int CurrentAccount { get; set; } //Розрахунковий рахунок
        public string IBAN { get; set; }//International Bank Account Number  
        //Формат коду IBAN:
        //1-2 символ — код країни(за стандартом ISO 3166-1 alpha-2), де розташований банк, який обслуговує відповідний IBAN
        //3-4 символ — контрольне число, що розраховується за алгоритмом MOD 97-10 (відповідно до стандарту ISO 7064)
        //5-34 символ — внутрішньодержавний номер рахунку(англ.Basic Bank Account Number — BBAN), що містить як власне номер рахунку, так і ознаку банку, який його обслуговує.Детальний зміст цієї частини визначається кожною країною, яка розробляє свій національний формат коду.
        //Довжина IBAN не може перевищувати 34 знаки.
        public string Comment { get; set; }
    }
}
