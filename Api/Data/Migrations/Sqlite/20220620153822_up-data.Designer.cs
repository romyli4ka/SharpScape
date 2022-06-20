﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpScape.Api.Data;

#nullable disable

namespace SharpScape.Api.Data.Migrations.Sqlite
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20220620153822_up-data")]
    partial class updata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("SharpScape.Api.Models.ForumCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ForumCategoryAuthor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ForumCategoryDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ForumCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ForumCategorys");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d45d377-770b-4f25-99bc-7993e69c5cb3"),
                            ForumCategoryAuthor = "Category Author 1",
                            ForumCategoryDescription = "Category Description 1",
                            ForumCategoryName = "Category Name 1"
                        },
                        new
                        {
                            Id = new Guid("b9878eed-e852-451a-a893-885b2d2fec68"),
                            ForumCategoryAuthor = "Category Author 2",
                            ForumCategoryDescription = "Category Description 2",
                            ForumCategoryName = "Category Name 2"
                        },
                        new
                        {
                            Id = new Guid("5c616052-2596-4cc4-8a8b-1cab79c698c4"),
                            ForumCategoryAuthor = "Category Author 3",
                            ForumCategoryDescription = "Category Description 3",
                            ForumCategoryName = "Category Name 3"
                        });
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumThread", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ForumCategoryId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ForumCategoryId");

                    b.ToTable("ForumThreads");
                });

            modelBuilder.Entity("SharpScape.Api.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumThread", b =>
                {
                    b.HasOne("SharpScape.Api.Models.ForumCategory", null)
                        .WithMany("Threads")
                        .HasForeignKey("ForumCategoryId");
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumCategory", b =>
                {
                    b.Navigation("Threads");
                });
#pragma warning restore 612, 618
        }
    }
}
