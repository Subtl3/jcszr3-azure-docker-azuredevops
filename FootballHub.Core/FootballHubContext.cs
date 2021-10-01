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
            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasIndex(e => e.Name);

                entity.ToTable("clubs");
                entity.Property(e => e.Name)
                    .HasColumnName("Name");
                entity.Property(e => e.League)
                    .HasColumnName("League");
                entity.Property(e => e.YearFounded)
                    .HasColumnName("YearFounded");
            });
            modelBuilder.Entity<Footballer>().ToTable("Footballers").HasNoKey();
        }
    }
}
