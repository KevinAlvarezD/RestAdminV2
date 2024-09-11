using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestAdminV2.Models;

namespace RestAdminV2.Seeders
{
    public class TableSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tables>().HasData(
               
                new Tables
                {
                    Id = 1,
                    Name = "Mesa 1",
                    State = "Cocinando"
                },
                 new Tables
                {
                    Id = 2,
                    Name = "Mesa 2",
                    State = "Por Facturar"
                },
                 new Tables
                {
                    Id = 3,
                    Name = "Mesa 3",
                    State = "Ocupada"
                },
                 new Tables
                {
                    Id = 4,
                    Name = "Mesa 4",
                    State = "Disponible"
                },
                 new Tables
                {
                    Id = 5,
                    Name = "Mesa 5",
                    State = "Disponible"
                }
         
            );
        }    
    }
}
