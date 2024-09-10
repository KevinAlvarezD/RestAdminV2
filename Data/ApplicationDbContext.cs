using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Tables> Tables { get; set; }

    public DbSet<Users> Users { get; set; }

    public DbSet<Invoice> Invoices { get; set; }

    public DbSet<Payment> Payments { get; set; }

    public DbSet<Ordered> Ordereds { get; set; }

    public DbSet<OrderDetails> OrderDetails { get; set; }

    public DbSet<Administrator> Administrators { get; set; }
    
    public DbSet<Categories> Categories { get; set; }

    public DbSet<Company> Companys { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


}


