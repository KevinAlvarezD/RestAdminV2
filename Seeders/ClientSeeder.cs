using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Seeders
{
    public class ClientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
               
                new Client
                {
                    Id = 1,
                    Name = "Juliana Carvajal",
                    Phone = "3242144893",
                    Address = "Cra 50a 36 90",
                },
                new Client
                {
                    Id = 2,
                    Name = "Alejandro Echavarria",
                    Phone = "3004001077",
                    Address = "Cra 50a 23-17",
                }
            );
        }    
    }
}
