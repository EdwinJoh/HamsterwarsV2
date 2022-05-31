using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
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
}
