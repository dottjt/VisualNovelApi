using Microsoft.EntityFrameworkCore;
using VisualNovelApi.Model;

namespace VisualNovelApi.Context
{
    public class NovelContext : DbContext
    {
        public NovelContext()
        {
        }

        public DbSet<Novel> Novels { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        // public DbSet<Scene> Scenes { get; set; }
        // public DbSet<Slide> Slides { get; set; }
        // public DbSet<Character> Characters { get; set; }
        // public DbSet<CharacterVariation> CharacterVariations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=Data/devDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("visual_novel");
            modelBuilder.Seed();
        }
    }
}
