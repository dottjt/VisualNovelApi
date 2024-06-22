using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VisualNovelApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialNovelAndChapter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "visual_novel");

            migrationBuilder.CreateTable(
                name: "Novels",
                schema: "visual_novel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CoverUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                schema: "visual_novel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    NovelId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_Novels_NovelId",
                        column: x => x.NovelId,
                        principalSchema: "visual_novel",
                        principalTable: "Novels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "visual_novel",
                table: "Novels",
                columns: new[] { "Id", "CoverUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("2327b08c-b4e6-49ab-8b6f-11f994d032fa"), null, "The Mystery Man" },
                    { new Guid("282ec692-f2c1-492e-abf6-ac6322b41f9a"), null, "Clannad 2" }
                });

            migrationBuilder.InsertData(
                schema: "visual_novel",
                table: "Chapters",
                columns: new[] { "Id", "NovelId", "Title" },
                values: new object[,]
                {
                    { new Guid("407cd494-01f1-41eb-b479-9cfd2797464c"), new Guid("282ec692-f2c1-492e-abf6-ac6322b41f9a"), "Chapter 1 - The girl dies" },
                    { new Guid("56855169-f445-4af0-b59b-28c11ecb011d"), new Guid("282ec692-f2c1-492e-abf6-ac6322b41f9a"), "Chapter 2 - The girl lives on!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_NovelId",
                schema: "visual_novel",
                table: "Chapters",
                column: "NovelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chapters",
                schema: "visual_novel");

            migrationBuilder.DropTable(
                name: "Novels",
                schema: "visual_novel");
        }
    }
}
