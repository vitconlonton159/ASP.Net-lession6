using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BstBookStore:DbContext
    {
        public BstBookStore():base { }
        public DbSet<BstCategory> BstCategories { get; set; }
        public DbSet<BstBook> BstBooks { get; set; }
    }
}