using lineupcreator.Components.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace lineupcreator.Components.Services;
public class FootballDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public FootballDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public DbSet<Player> Players { get; set; }
    public DbSet<Club> Clubs { get; set; }
    public DbSet<Nation> Nations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Az adatbázis kapcsolat beállítása (pl. SQL Server)
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(Configuration.GetConnectionString("Mydb"));
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().ToTable("player").HasKey(p => p.sofifa_id);
        modelBuilder.Entity<Club>().ToTable("club").HasKey(c => c.club_team_id);
        modelBuilder.Entity<Nation>().ToTable("nationality").HasKey(n => n.nationality_id);

        modelBuilder.Entity<Player>()
            .HasOne(p => p.Club)
            .WithMany(c => c.Players)
            .HasForeignKey(p => p.club_team_id)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Player>()
            .HasOne(p => p.Nation)
            .WithMany(n => n.Players)
            .HasForeignKey(p => p.nationality_id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}