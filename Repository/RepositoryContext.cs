using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;
/// <summary>
/// Repositorycontext that talks to the database and register the tables that are in there,
/// the ovveride method creates testdata to the database when migrate and update it.
/// </summary>
public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new HamsterConfiguration());
        modelBuilder.ApplyConfiguration(new MatchConfiguration());
    }
    public DbSet<Hamster> Hamsters { get; set; }
    public DbSet<Matches> Matches { get; set; }
    public DbSet<User> Users { get; set; }
}
