﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisualNovelApi.Context;

#nullable disable

namespace VisualNovelApi.Migrations
{
    [DbContext(typeof(NovelDbContext))]
    [Migration("20240622043249_InitialNovelAndChapter")]
    partial class InitialNovelAndChapter
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("visual_novel")
                .HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("VisualNovelApi.Model.Chapter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("NovelId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("NovelId");

                    b.ToTable("Chapters", "visual_novel");

                    b.HasData(
                        new
                        {
                            Id = new Guid("407cd494-01f1-41eb-b479-9cfd2797464c"),
                            NovelId = new Guid("282ec692-f2c1-492e-abf6-ac6322b41f9a"),
                            Title = "Chapter 1 - The girl dies"
                        },
                        new
                        {
                            Id = new Guid("56855169-f445-4af0-b59b-28c11ecb011d"),
                            NovelId = new Guid("282ec692-f2c1-492e-abf6-ac6322b41f9a"),
                            Title = "Chapter 2 - The girl lives on!"
                        });
                });

            modelBuilder.Entity("VisualNovelApi.Model.Novel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Novels", "visual_novel");

                    b.HasData(
                        new
                        {
                            Id = new Guid("282ec692-f2c1-492e-abf6-ac6322b41f9a"),
                            Title = "Clannad 2"
                        },
                        new
                        {
                            Id = new Guid("2327b08c-b4e6-49ab-8b6f-11f994d032fa"),
                            Title = "The Mystery Man"
                        });
                });

            modelBuilder.Entity("VisualNovelApi.Model.Chapter", b =>
                {
                    b.HasOne("VisualNovelApi.Model.Novel", "Novel")
                        .WithMany("Chapters")
                        .HasForeignKey("NovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Novel");
                });

            modelBuilder.Entity("VisualNovelApi.Model.Novel", b =>
                {
                    b.Navigation("Chapters");
                });
#pragma warning restore 612, 618
        }
    }
}
