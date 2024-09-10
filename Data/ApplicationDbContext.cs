using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Models;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Kitchen> Kitchens { get; set; }

    public DbSet<Tables> Tables { get; set; }

    public DbSet<Users> Users { get; set; }

    public DbSet<Invoice> Invoices { get; set; }

    public DbSet<PreInvoice> PreInvoices { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Client> Clients { get; set; }
    
    public DbSet<Categories> Categories { get; set; }

    public DbSet<Company> Companys { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }



}


