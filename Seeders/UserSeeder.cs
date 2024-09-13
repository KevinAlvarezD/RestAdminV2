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
                    PasswordHash = PasswordHelper.HashPassword("riwi1234"),
                    Phone = "3242144893",
                    Address = "Cra 50 40 90",
                    RoleId = 1
                },
                new User
                {
                    Id = 2,
                    Name = "Alejandro Echavarria",
                    Email = "aechavarriaj@gmail.com",
                    PasswordHash = PasswordHelper.HashPassword("Susana1901"),
                    Phone = "3004001077",
                    Address = "Cra 50a 36 90",
                    RoleId = 2
                },
                new User
                {
                    Id = 3,
                    Name = "Alejandro Castrillón",
                    Email = "alejomi192005@gmail.com",
                    PasswordHash = PasswordHelper.HashPassword("21354"),
                    Phone = "333245884",
                    Address = "Cra 59a 66 57",
                    RoleId = 3
                },
                new User
                {
                    Id = 4,
                    Name = "Alejandro Londoño",
                    Email = "Alejandro@gmail.com",
                    PasswordHash = PasswordHelper.HashPassword("12345678"), // Contraseña hasheada
                    Phone = "3123456789",
                    Address = "Cra 45 67 89",
                    RoleId = 2
                },
                new User
                {   
                    Id = 5,
                    Name = "Kevin Alvarez",
                    Email = "kev@gmail.com",
                    PasswordHash = PasswordHelper.HashPassword("987654321"), // Contraseña hasheada
                    Phone = "3132145678",
                    Address = "Cra 40 50 60",
                    RoleId = 2
                },
                new User
                {
                    Id = 6,
                    Name = "Laura Jimenez",
                    Email = "laura.jimenez@restadmin.com",
                    PasswordHash = PasswordHelper.HashPassword("laura2024"), // Contraseña hasheada
                    Phone = "3221234567",
                    Address = "Cra 55 33 44",
                    RoleId = 3
                },
                new User
                {
                    Id = 7,
                    Name = "Carlos Mejia",
                    Email = "carlos.mejia@restadmin.com",
                    PasswordHash = PasswordHelper.HashPassword("admin2024"), // Contraseña hasheada
                    Phone = "3209876543",
                    Address = "Cra 60 35 78",
                    RoleId = 1
                },
                new User
                {
                    Id = 8,
                    Name = "Diana Lopez",
                    Email = "diana.lopez@restadmin.com",
                    PasswordHash = PasswordHelper.HashPassword("cashier2024"), // Contraseña hasheada
                    Phone = "3111239876",
                    Address = "Cra 42 55 88",
                    RoleId = 1
                }
            );
        }    
    }
}
