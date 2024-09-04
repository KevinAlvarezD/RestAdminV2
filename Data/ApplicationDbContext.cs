using Microsoft.EntityFrameworkCore;
using RestAdmin.Models;

namespace RestAdminV2.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Table> Tables { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Invoice> Invoices { get; set; }

    public DbSet<Payment> Payments { get; set; }

    public DbSet<Ordered> Ordereds { get; set; }

    public DbSet<OrderDetails> OrderDetails { get; set; }

    public DbSet<Administrator> Administrators { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Invoice>()
        .HasOne(i => i.Ordered)
        .WithMany() 
        .HasForeignKey(i => i.IdOrder)
        .OnDelete(DeleteBehavior.Restrict); 

    modelBuilder.Entity<Ordered>()
        .HasOne(o => o.Customer)
        .WithMany()
        .HasForeignKey(o => o.IdCustomer)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Ordered>()
        .HasOne(o => o.Table)
        .WithMany()
        .HasForeignKey(o => o.IdTable)
        .OnDelete(DeleteBehavior.Restrict);

    // Configuración adicional para otras entidades
}

}


