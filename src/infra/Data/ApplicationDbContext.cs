using IWantApp.Domain.Products;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace IWantApp.infra.Data;
public class ApplicationDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }

    protected override object OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
             .Property(p => p.Name).IsRequired();
        modelBuilder.Entity<Product>()
             .Property(p => p.Description).HasMaxLength(255);
        modelBuilder.Entity<Category>()
             .Property(c => c.Name).IsRequired;
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<string>()
            .HaveMaxLength(100);
    }
}
