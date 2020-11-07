using System;
using System.Linq;
using authproject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace authproject.Data
{
    public class ProductDbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = new ProductDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProductDbContext>>());
            
            context.Database.EnsureCreated();


            if (context.ProductsTb.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product(1, "Awesome shoe", 50, "https://storage.googleapis.com/hippodrome/shoe1.png", "8UK,9UK,10UK,11UK,12UK", 20, 1),
                new Product(2, "Better shoe", 50, "https://storage.googleapis.com/hippodrome/shoe3.png", "8UK,9UK,10UK,11UK,12UK", 20, 1),
                new Product(3, "New shoe", 70, "https://storage.googleapis.com/hippodrome/shoe2.png", "8UK,9UK,10UK", 10, 1),
                new Product(4, "Best shoe", 60, "https://storage.googleapis.com/hippodrome/shoe4.png", "8UK,9UK,10UK", 20, 1),
                new Product(5, "Shirt 1", 25, "https://storage.googleapis.com/hippodrome/shirt1.png", "S,M,L,XL", 20, 2),
                new Product(6, "Shirt 2", 30, "https://storage.googleapis.com/hippodrome/shirt2.png", "S,M,L,XL", 20, 2),
                new Product(7, "Shirt 3", 30, "https://storage.googleapis.com/hippodrome/shirt3.png", "S,M,L", 20, 2),

        };

            context.ProductsTb.AddRange(products);
            context.SaveChanges();


        }
    }
}