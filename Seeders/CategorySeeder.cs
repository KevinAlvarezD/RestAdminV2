using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Seeders
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(

                new Categories
                {
                    Id = 1,
                    Name = "Bebidas",
                },
                new Categories
                {
                    Id = 2,
                    Name = "Comidas",
                },
                new Categories
                {
                    Id = 3,
                    Name = "Postres",
                },
                new Categories
                {
                    Id = 4,
                    Name = "Entradas",
                },
                new Categories
                {
                    Id = 5,
                    Name = "Domicilios",
                }
            );
        }
    }
}
