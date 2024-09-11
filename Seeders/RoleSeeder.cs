using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Seeders
{
    public class RoleSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Mesero"
                },
                new Role
                {
                    Id = 2,
                    Name = "Administrador"
                },
                new Role
                {
                    Id = 3,
                    Name = "Cajero"
                }
            );
        }
        
    }
}