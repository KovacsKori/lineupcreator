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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Az adatbázis kapcsolat beállítása (pl. SQL Server)
        //optionsBuilder.UseSqlServer("Data Source=DESKTOP-F4N9UQK;Initial Catalog=lineupcreator;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Mydb"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().ToTable("playerstable$").HasKey(p => p.sofifa_id);
        modelBuilder.Entity<Player>().Property(p => p.sofifa_id).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.overall).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.age).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.height_cm).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.club_team_id).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.club_jersey_number).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.nationality_id).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.weak_foot).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.skill_moves).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.pace).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.shooting).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.passing).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.dribbling).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.defending).HasColumnType("float");
        modelBuilder.Entity<Player>().Property(p => p.physic).HasColumnType("float"); ;               
    }
}