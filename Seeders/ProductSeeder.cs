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
                    CategoryId = 1,
            
                },
                new Product
                {
                    Id = 2,
                    Name = "Hamburguesa",
                    Price = 18000,
                    Cost = 9000,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641834/oeicuuwbem09deuyizwp.jpg",
                    CategoryId = 2,
                    
                },
                new Product
                {
                    Id = 3,
                    Name = "Pizza Peperoni",
                    Price = 22000,
                    Cost = 12000,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641861/ix9ooxdajnvxijwq7bwv.jpg",
                    CategoryId = 2,
                    
                },
                new Product
                {
                    Id = 4,
                    Name = "Postobon 1.5lt",
                    Price = 7000,
                    Cost = 3500,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669032/zoc4meht10bhophsaz7z.jpg",
                    CategoryId = 1,
                    
                },
                new Product
                {
                    Id = 5,
                    Name = "Michelada clasica",
                    Price = 5000,
                    Cost = 2500,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669102/wtymyqe8qug10utjrhmj.jpg",
                    CategoryId = 1,
                    
                },
                new Product
                {
                    Id = 6,
                    Name = "Michelada cereza",
                    Price = 7000,
                    Cost = 3500,
                    ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669255/kg6sllhrux2qs3wogknz.jpg",
                    CategoryId = 1,
                    
                },
                new Product
                {
                    Id = 7,
                    Name = "Bruschetta",
                    Price = 12000,
                    Cost = 5000,
                    ImageURL = "https://assets.unileversolutions.com/recipes-v2/219942.jpg",
                    CategoryId = 4,
                    
                },
                new Product
                {
                    Id = 8,
                    Name = "Tacos al Pastor",
                    Price = 25000,
                    Cost = 12000,
                    ImageURL = "https://www.jocooks.com/wp-content/uploads/2022/04/tacos-al-pastor-feature-1.jpg",
                    CategoryId = 4,
                    
                },
                new Product
                {
                    Id = 9,
                    Name = "Ceviche",
                    Price = 7000,
                    Cost = 3500,
                    ImageURL = "https://www.elespectador.com/resizer/tyGJPN_YmWpagQFeXq_YYOxAKjY=/arc-anglerfish-arc2-prod-elespectador/public/2AVD5Z6Y2ZFWHETPQGCPLMNK4A.jpg",
                    CategoryId = 4,
                   
                },
                new Product
                {
                    Id = 10,
                    Name = "Cheesecake",
                    Price = 7000,
                    Cost = 3500,
                    ImageURL = "https://escuelamundopastel.com/wp-content/uploads/2018/11/ORGANIZACI%C3%93N-DE-EVENTOS-10.png",
                    CategoryId = 3,
                   
                },
                new Product
                {
                    Id = 11,
                    Name = "Brownie",
                    Price = 6000,
                    Cost = 3500,
                    ImageURL = "https://badun.nestle.es/imgserver/v1/80/1290x742/ac5fa47c04dd-brownie-de-chocolate-negro.jpg",
                    CategoryId = 3,
                    
                },
                new Product
                {
                    Id = 12,
                    Name = "Tiramisu",
                    Price = 7000,
                    Cost = 3500,
                    ImageURL = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/6BE1C69C-69FB-4957-96EA-D76159076661/Derivates/BA406212-38AE-4EA0-B4D5-591514C21C2D.jpg",
                    CategoryId = 3,
                   
                }

            );
        }
    }
}