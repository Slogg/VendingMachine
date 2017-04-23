using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VendingMach.Models
{
    public class VendingContext:DbContext
    {
        public DbSet<Beverage> Beverages { get; set; }
    }
}