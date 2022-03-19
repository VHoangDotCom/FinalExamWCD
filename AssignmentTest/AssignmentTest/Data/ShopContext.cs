using AssignmentTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AssignmentTest.Data
{
    public class ShopContext : DbContext
    {

        public ShopContext() : base("ConnectionString")
        {
        }

         public DbSet<Product> Products { get; set; }
         public DbSet<Category> Categories { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}