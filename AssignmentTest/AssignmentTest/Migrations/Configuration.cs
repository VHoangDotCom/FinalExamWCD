namespace AssignmentTest.Migrations
{
    using AssignmentTest.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AssignmentTest.Data.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AssignmentTest.Data.ShopContext context)
        {
            var categories = new List<Category>
            {
                new Category{ID=234, CategoryName = "Shirt"},
                new Category{ID=142,CategoryName = "Jean"},
                new Category{ID=412,CategoryName = "Hat"},
                new Category{ID=214,CategoryName = "Shoes"},
                new Category{ID=521,CategoryName = "Underware"},
                new Category{ID=143,CategoryName = "Condom"},
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{ CateID = 234, ProductName = "ÁO SƠ MI DÀI TAY BÉ TRAI RABITY 9900",Price =150000 },
                new Product{CateID = 234,ProductName = "ÁO SƠ MI NGẮN TAY BÉ TRAI RABITY 91121",Price =229000 },
                new Product{CateID = 234,ProductName = "ÁO SƠ MI NGẮN TAY BÉ TRAI RABITY 91121",Price =229000 },
                 new Product{CateID = 142,ProductName = "ĐẦM JEAN MICKEY BÉ GÁI RABITY 5541",Price =299000 },
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
