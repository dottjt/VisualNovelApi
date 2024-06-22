
using Microsoft.EntityFrameworkCore;
using VisualNovelApi.Model;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var clanndTwoNovelId = 1;
        modelBuilder.Entity<Novel>().HasData(
            new Novel
            {
                Id = clanndTwoNovelId,
                Title = "Clannad 2",
            },
            new Novel
            {
                Id = 2,
                Title = "The Mystery Man",
            }
        );

        modelBuilder.Entity<Chapter>().HasData(
            new Chapter
            {
                Id = 1,
                Title = "Chapter 1 - The girl dies",
                NovelId = clanndTwoNovelId,
            },
            new Chapter
            {
                Id = 2,
                Title = "Chapter 2 - The girl lives on!",
                NovelId = clanndTwoNovelId,
            }
        );
    }
}
