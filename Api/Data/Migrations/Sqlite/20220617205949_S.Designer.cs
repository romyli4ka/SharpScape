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
    [Migration("20220617205949_S")]
    partial class S
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

                    b.HasKey("Id");

                    b.ToTable("ForumCategorys");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c3429b33-bcb2-4dc3-9975-ab1dfcb026b3")
                        },
                        new
                        {
                            Id = new Guid("556073be-f19b-4f09-a928-41f4ca3f88b2")
                        },
                        new
                        {
                            Id = new Guid("b89fc9f0-f242-4088-80c9-1c4c1696fc6a")
                        });
                });

            modelBuilder.Entity("SharpScape.Api.Models.ForumThread", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

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
#pragma warning restore 612, 618
        }
    }
}
