using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

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
    
    public DbSet<Category> Categorys { get; set; }

    public DbSet<Company> Companys { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }


}


