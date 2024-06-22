
using Microsoft.EntityFrameworkCore;
using VisualNovelApi.Model;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var clannadTwoNovelId = Guid.NewGuid();
        var theMysteryManNovelId = Guid.NewGuid();
        modelBuilder.Entity<Novel>().HasData(
            new Novel
            {
                Id = clannadTwoNovelId,
                Title = "Clannad 2",
            },
            new Novel
            {
                Id = theMysteryManNovelId,
                Title = "The Mystery Man",
            }
        );

        var chapterOneChapterId = Guid.NewGuid();
        var chapterTwoChapterId = Guid.NewGuid();
        modelBuilder.Entity<Chapter>().HasData(
            new Chapter
            {
                Id = chapterOneChapterId,
                Title = "Chapter 1 - The girl dies",
                NovelId = clannadTwoNovelId,
            },
            new Chapter
            {
                Id = chapterTwoChapterId,
                Title = "Chapter 2 - The girl lives on!",
                NovelId = clannadTwoNovelId,
            }
        );
    }
}
