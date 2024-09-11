using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Seeders
{
    public class CompanySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(

                new Company
                {
                    Id = 1,
                    Name = "Il Forno",
                    Email = "administracionilforno@ilforno.com",
                    Nit = "49879684184",
                    Phone = "3242144893",
                    Address = "Cra 50 40 90",
                    LogoURL = "https://images.rappi.com/restaurants_logo/il-forno-logo1-1568819470999.png"
                }
            );
        }
    }
}
