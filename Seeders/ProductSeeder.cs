using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Seeders
{
    public class ProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    Id = 1,
                    Name = "Coca cola 400ml",
                    Price = 3500, 
                    Cost = 2100, 
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641772/j1sfl0ooipp2lfnaznbx.jpg", 
                    Category = "Bebidas" 
                    },
                new Product {
                    Id = 2,
                    Name = "Hamburguesa",
                    Price = 18000, 
                    Cost = 9000, 
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641834/oeicuuwbem09deuyizwp.jpg", 
                    Category = "Comida"
                }
            );
        }
    }
}