using FootballHub.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballHub.Core
{
    public class FootballHubContext : DbContext
    {
        public FootballHubContext(DbContextOptions<FootballHubContext> options) : base(options)
        {

        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Footballer> Footballers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().ToTable("Clubs");
            modelBuilder.Entity<Footballer>().ToTable("Footballers");
        }
    }
}
