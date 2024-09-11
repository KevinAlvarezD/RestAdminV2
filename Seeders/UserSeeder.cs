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
                    Id = 1,
                    Name = "Erik Uribe",
                    Email = "erik@elmejor.com",
                    Password =  "riwi1234",
                    Phone = "3242144893",
                    Address = "Cra 50 40 90",
                    Role = "Mesero"
                },
                new User
                {
                    Id = 2,
                    Name = "Alejandro Echavarria",
                    Email = "aechavarriaj@gmail.com",
                    Password =  "Susana1901",
                    Phone = "3004001077",
                    Address = "Cra 50a 36 90",
                    Role = "Administrador"
                },
                new User
                {
                    Id = 3,
                    Name = "Alejandro Castrillón",
                    Email = "alejomi192005@gmail.com",
                    Password =  "21354",
                    Phone = "333245884",
                    Address = "Cra 59a 66 57",
                    Role = "Cajero"
                },
                new User
                {
                    Id = 4,
                    Name = "Mickey Londoño",
                    Email = "Mickey@gmail.com",
                    Password =  "12345678",
                    Phone = "3123456789",
                    Address = "Cra 45 67 89",
                    Role = "Mesero"
                },
                new User
                {   
                    Id = 5,
                    Name = "Kevin Alvarez",
                    Email = "kev@gmail.com",
                    Password =  "987654321",
                    Phone = "3132145678",
                    Address = "Cra 40 50 60",
                    Role = "Administrador"
                },
                new User
                {
                    Id = 6,
                    Name = "Laura Jimenez",
                    Email = "laura.jimenez@restadmin.com",
                    Password = "laura2024",
                    Phone = "3221234567",
                    Address = "Cra 55 33 44",
                    Role = "Mesero"
                },
                new User
                {
                    Id = 7,
                    Name = "Carlos Mejia",
                    Email = "carlos.mejia@restadmin.com",
                    Password = "admin2024",
                    Phone = "3209876543",
                    Address = "Cra 60 35 78",
                    Role = "Administrador"
                },
                new User
                {
                    Id = 8,
                    Name = "Diana Lopez",
                    Email = "diana.lopez@restadmin.com",
                    Password = "cashier2024",
                    Phone = "3111239876",
                    Address = "Cra 42 55 88",
                    Role = "Cajero"
                }
            );
        }    
    }
}
