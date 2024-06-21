
using Microsoft.EntityFrameworkCore;
using VisualNovelApi.Model;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // var chapterOne = new Chapter
        // {
        //     Id = 1,
        //     Title = "Chapter 1 - The girl dies",
        // };

        // var chapterTwo = new Chapter
        // {
        //     Id = 2,
        //     Title = "Chapter 2 - The girl lives on!",
        // };

        var novelId = 1;
        modelBuilder.Entity<Novel>().HasData(
            new Novel
            {
                Id = novelId,
                Title = "Clannad 2",
                // Chapters = [
                //     chapterOne,
                //     chapterTwo,
                // ],
            },
            new Novel
            {
                Id = 2,
                Title = "The Mystery Man",
            }
        );
    }
}
