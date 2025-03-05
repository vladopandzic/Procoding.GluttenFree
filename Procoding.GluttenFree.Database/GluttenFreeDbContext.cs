using Microsoft.EntityFrameworkCore;
using Procoding.GluttenFree.Models;

namespace Procoding.GluttenFree.Database;

public class GluttenFreeDbContext : DbContext
{
    public GluttenFreeDbContext(DbContextOptions<GluttenFreeDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);

        base.OnModelCreating(modelBuilder);
    }
}