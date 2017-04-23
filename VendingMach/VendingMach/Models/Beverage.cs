using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace VendingMach.Models
{
    public class Beverage
    {
        public int Id { get; set; }
        [DisplayName("Имя:")]
        public string Name { get; set; }
        [DisplayName("Цена:")]
        public int Price { get; set; }
        [DisplayName("Количество:")]
        public int Count { get; set; }
    }
}