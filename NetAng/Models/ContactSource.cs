using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Models
{
    public class ContactSource
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }//Дзвінок  //Електронна пошта  //Веб-сайт  //Реклама   //Існуючий клієнт   //По рекомендації   //Виставка  //CRM-форма //Зворотний дзвінок //Генератор продажів    //Інтернет-магазин //Інше
    }
}
