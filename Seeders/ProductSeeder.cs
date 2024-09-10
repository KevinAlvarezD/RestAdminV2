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
                new Product
                {
                    Id = 1,
                    Name = "Coca cola 400ml",
                    Price = 3500,
                    Cost = 2100,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641772/j1sfl0ooipp2lfnaznbx.jpg",
                    Category = "Bebidas"
                },
                new Product
                {
                    Id = 2,
                    Name = "Hamburguesa",
                    Price = 18000,
                    Cost = 9000,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641834/oeicuuwbem09deuyizwp.jpg",
                    Category = "Comida"
                },
                new Product
                {
                    Id = 3,
                    Name = "Pizza Peperoni",
                    Price = 22000,
                    Cost = 12000,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641861/ix9ooxdajnvxijwq7bwv.jpg",
                    Category = "Comida"
                },
                new Product
                {
                    Id = 4,
                    Name = "Postobon 1.5lt",
                    Price = 7000,
                    Cost = 3500,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669032/zoc4meht10bhophsaz7z.jpg",
                    Category = "Bebidas"
                },
                new Product
                {
                    Id = 5,
                    Name = "Michelada clasica",
                    Price = 5000,
                    Cost = 2500,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669102/wtymyqe8qug10utjrhmj.jpg",
                    Category = "Bebidas"
                },
                new Product
                {
                    Id = 6,
                    Name = "Michelada cereza",
                    Price = 7000,
                    Cost = 3500,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669255/kg6sllhrux2qs3wogknz.jpg",
                    Category = "Bebidas"
                }
            );
        }
    }
}