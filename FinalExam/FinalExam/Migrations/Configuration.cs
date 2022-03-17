namespace FinalExam.Migrations
{
    using FinalExam.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalExam.Data.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalExam.Data.ShopContext context)
        {
            var categories = new List<Category>
            {
                new Category{ID=234, CategoryName = "Shirt", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=235, CategoryName = "Jeans", Description="nice",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=236, CategoryName = "Shoes", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=237, CategoryName = "Shorts", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=238, CategoryName = "Shit", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
                new Category{ID=239, CategoryName = "Pepe", Description="none",Picture="https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Fb%2Fb6%2FImage_created_with_a_mobile_phone.png%2F640px-Image_created_with_a_mobile_phone.png&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FImage&tbnid=ItY9cBsepnqjwM&vet=12ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ..i&docid=0JWe7yDOKrVFAM&w=640&h=480&q=image&ved=2ahUKEwjU7fGci832AhXETPUHHS7XAHsQMygAegUIARDWAQ"},
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{ CateID = 234, ProductName = "ÁO SƠ MI DÀI TAY BÉ TRAI RABITY 9900",SuppilerID = 231,QuantityPerUnit=5,UnitPrice =150000,UnitsInStock="Jeans",UnitsOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ CateID = 236, ProductName = "ÁO SƠ MI DÀ00",SuppilerID = 231,QuantityPerUnit=5,UnitPrice =1505000,UnitsInStock="Condom",UnitsOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ CateID = 237, ProductName = "ÁO SƠ900",SuppilerID = 231,QuantityPerUnit=54,UnitPrice =1520000,UnitsInStock="Shorts",UnitsOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ CateID = 235, ProductName = "ÁO SƠ MI DÀ00",SuppilerID = 231,QuantityPerUnit=6,UnitPrice =1520000,UnitsInStock="Hat",UnitsOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ CateID = 238, ProductName = "TRAI RABITY 9900",SuppilerID = 231,QuantityPerUnit=23,UnitPrice =1250000,UnitsInStock="Jeans",UnitsOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
                new Product{ CateID = 239, ProductName = "ÁO S RABITY 9900",SuppilerID = 231,QuantityPerUnit=65,UnitPrice =1250000,UnitsInStock="Hat",UnitsOnOrder="Shorts",ReorderLevel="12",Discontinued="no" },
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
