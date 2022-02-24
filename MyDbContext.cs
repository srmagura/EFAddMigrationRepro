using Microsoft.EntityFrameworkCore;

namespace EFAddMigrationRepro;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // This connection string is for Windows, change if you are on Linux
        optionsBuilder.UseSqlServer("Server=localhost;Database=EFAddMigrationRepro;TrustServerCertificate=True;MultipleActiveResultSets=True;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>()
            .HasMany(p => p.Imports)
            .WithOne(i => i.Project)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<Import> Imports => Set<Import>();
    public DbSet<Project> Projects => Set<Project>();
}
