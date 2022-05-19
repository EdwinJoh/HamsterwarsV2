using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options ) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new HamsterConfiguration());
            modelBuilder.ApplyConfiguration(new MatchConfiguration());

        }
        public DbSet<Hamster> Hamsters { get; set; }
        public DbSet<Matches> Matches { get; set; }
    }
}
