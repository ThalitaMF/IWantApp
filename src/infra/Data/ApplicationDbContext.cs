
using IWantApp.Domain.Products;

namespace IWantApp.infra.Data;
public class ApplicationDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
       
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<string>()
            .HaveMaxLength(100);
    }
}
