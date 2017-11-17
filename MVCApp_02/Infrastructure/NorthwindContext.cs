using MVCApp_02.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp_02.Infrastructure
{
    public class NorthwindContext : DbContext
    {
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}