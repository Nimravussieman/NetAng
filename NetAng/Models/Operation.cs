using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using money;
namespace NetAng.Models
{
    public class Operation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Money Amount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DateOfChange { get; set; }
        public DateTime EndDate { get; set; }
        public Phase Phase { get; set; }
        public OperationType TypeOfOperation { get; set; }
        public string Description { get; set; }
        public bool AvailableToEveryone { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Company> Contractors { get; set; }
        public OperationFieldsPermissions Permissions { get; set; }
        //void fu()
        //{
        //    Money a = new money.Money(0.99);
        //    Money b = new money.Money(0.99);
        //    Money c = a + b.;
        //    money.Currency. cc = 
        //}
    }
}

