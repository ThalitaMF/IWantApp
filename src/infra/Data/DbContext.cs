using Microsoft.EntityFrameworkCore;

namespace IWantApp.infra.Data;

public class DbContext
{
    public DbContext(DbContextOptions<ApplicationDbContext> options)
    {
    }
}