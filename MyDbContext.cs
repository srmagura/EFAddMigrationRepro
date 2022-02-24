using Microsoft.EntityFrameworkCore;

namespace EFAddMigrationRepro;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // This connection string is for Windows, change if you are on Linux
        optionsBuilder.UseSqlServer("Server=localhost;Database=EFAddMigrationRepro;TrustServerCertificate=True;MultipleActiveResultSets=True;Trusted_Connection=True;");
    }

    public DbSet<Import> Imports => Set<Import>();
}
