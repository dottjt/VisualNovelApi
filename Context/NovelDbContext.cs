using Microsoft.EntityFrameworkCore;
using VisualNovelApi.Model;

namespace VisualNovelApi.Context;

public class NovelDbContext : DbContext
{
    public DbSet<Novel> Novels { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    // public DbSet<Scene> Scenes { get; set; }
    // public DbSet<Slide> Slides { get; set; }
    // public DbSet<Character> Characters { get; set; }
    // public DbSet<CharacterVariation> CharacterVariations { get; set; }

    public NovelDbContext() : base() {}
    public NovelDbContext(DbContextOptions<NovelDbContext> options) : base(options) {}

    // NOTE: No longer needed
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=Data/devDatabase.db");
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("visual_novel");
        modelBuilder.Seed();
    }
}
