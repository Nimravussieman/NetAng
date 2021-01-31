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
        public string Phase { get; set; }
        public string OperationSource { get; set; }
        public string TypeOfOperation { get; set; }
        public string Description { get; set; }
        public bool AvailableToEveryone { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Company> Contractors { get; set; }
        public bool IsAccount { get; set; } = true;
        public OperationFieldsPermissions Permissions { get; set; } = new OperationFieldsPermissions()
        {
            IsPublic = true,
            Amount_IsPublic = true,
            CreateDate_IsPublic = true,
            DateOfChange_IsPublic = false,
            EndDate_IsPublic = true,
            Phase_IsPublic = true,
            TypeOfOperation_IsPublic = true,
            Description_IsPublic = true,
            AvailableToEveryone_IsPublic = false,
            Contacts_IsPublic = false,
            Contractors_IsPublic = false,
            Permissions_IsPublic = false

        };
        //void fu()
        //{
        //    Money a = new money.Money(0.99);
        //    Money b = new money.Money(0.99);
        //    Money c = a + b.;
        //    money.Currency. cc = 
        //}
    }
}

