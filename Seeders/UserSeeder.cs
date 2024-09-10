using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Seeders
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 172443449,
                    Name = "Erik Uribe",
                    Email = "erik@elmejor.com",
                    Password =  "riwi1234",
                    Phone = "3242144893",
                    Address = "Cra 50 40 90",
                    Role = "Administrator"
                },
                new User
                {
                    Id = 1724434496,
                    Name = "Alejandro Echavarria",
                    Email = "aechavarriaj@gmail.com",
                    Password =  "Susana1901",
                    Phone = "3004001077",
                    Address = "Cra 50a 36 90",
                    Role = "Administrator"
                },
                new User
                {
                    Id = 1724434496,
                    Name = "Alejandro Castrillón",
                    Email = "alejomi192005@gmail.com",
                    Password =  "21354",
                    Phone = "333245884",
                    Address = "Cra 59a 66 57",
                    Role = "Administrator"
                },
                new User{
                    Id = 1724434497,
                    Name = "Mickey Londoño",
                    Email = "Mickey@gmail.com",
                    Password =  "12345678",
                    Phone = "3123456789",
                    Address = "Cra 45 67 89",
                    Role = "Administrator"
                },
                new User
                {   
                    Id = 1724434498,
                    Name = "Kevin Alvarez",
                    Email = "kev@gmail.com",
                    Password =  "987654321",
                    Phone = "3132145678",
                    Address = "Cra 40 50 60",
                    Role = "Administrator"
                }
            );
        }    
    }
}