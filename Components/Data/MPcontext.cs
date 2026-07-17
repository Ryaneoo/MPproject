using Microsoft.EntityFrameworkCore;
using MP.Components.Models;
using MP.Components.Seeding;
namespace MP.Components.Data;

public class MPcontext : DbContext
{
    public MPcontext(DbContextOptions<MPcontext> options)
        : base(options)
    {
    }

    public DbSet<Games> Games { get; set; } = default!;
    public DbSet<Lessons> Lessons   { get; set; } = default!;
    public DbSet<LeaderboardConfig> Boards { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LessonsSeeding());
        modelBuilder.ApplyConfiguration(new GamesSeeding());
        modelBuilder.ApplyConfiguration(new LeaderboardSeeding());
    }
}