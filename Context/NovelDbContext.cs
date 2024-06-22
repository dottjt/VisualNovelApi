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
            optionsBuilder.UseSqlite($"Data Source=devDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("visual_novel");
            modelBuilder.Seed();
        }
    }
}

// using Microsoft.EntityFrameworkCore;
// using System;
// using System.Collections.Generic;

// namespace VisualNovelApi.Context;

// public class BloggingContext : DbContext
// {
//     public DbSet<Blog> Blogs { get; set; }
//     public DbSet<Post> Posts { get; set; }

//     public string DbPath { get; }

//     public BloggingContext()
//     {
//         var folder = Environment.SpecialFolder.LocalApplicationData;
//         var path = Environment.GetFolderPath(folder);
//         DbPath = System.IO.Path.Join(path, "blogging.db");
//     }

//     // The following configures EF to create a Sqlite database file in the
//     // special "local" folder for your platform.
//     protected override void OnConfiguring(DbContextOptionsBuilder options)
//         => options.UseSqlite($"Data Source={DbPath}");
// }

// public class Blog
// {
//     public int BlogId { get; set; }
//     public string Url { get; set; }

//     public List<Post> Posts { get; } = new();
// }

// public class Post
// {
//     public int PostId { get; set; }
//     public string Title { get; set; }
//     public string Content { get; set; }

//     public int BlogId { get; set; }
//     public Blog Blog { get; set; }
// }
