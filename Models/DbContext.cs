using Microsoft.EntityFrameworkCore;

namespace CIDM3312Final.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GameCharacter>().HasKey(s => new {s.GameID, s.CharacterID});
    }

    public DbSet<Game> Games {get; set;}
    public DbSet<Character> Characters {get; set;}
    public DbSet<GameCharacter> GameCharacters {get; set;}
}