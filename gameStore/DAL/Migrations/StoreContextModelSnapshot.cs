﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.DAL.EF;

namespace Store.DAL.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Store.DAL.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<int?>("GameId");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("ParentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Store.DAL.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("PublisherId");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Store.DAL.Entities.GamePlatformType", b =>
                {
                    b.Property<int>("GameId");

                    b.Property<int>("PlatformTypeId");

                    b.HasKey("GameId", "PlatformTypeId");

                    b.HasIndex("PlatformTypeId");

                    b.ToTable("GamePlatformType");
                });

            modelBuilder.Entity("Store.DAL.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.HasIndex("ParentId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Store.DAL.Entities.GenreGame", b =>
                {
                    b.Property<int>("GenreId");

                    b.Property<int>("GameId");

                    b.HasKey("GenreId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GenreGame");
                });

            modelBuilder.Entity("Store.DAL.Entities.PlatformType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAlternateKey("Type");

                    b.ToTable("PlatformTypes");
                });

            modelBuilder.Entity("Store.DAL.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Store.DAL.Entities.Comment", b =>
                {
                    b.HasOne("Store.DAL.Entities.Game", "Game")
                        .WithMany("Comments")
                        .HasForeignKey("GameId");

                    b.HasOne("Store.DAL.Entities.Comment", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Store.DAL.Entities.Game", b =>
                {
                    b.HasOne("Store.DAL.Entities.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId");
                });

            modelBuilder.Entity("Store.DAL.Entities.GamePlatformType", b =>
                {
                    b.HasOne("Store.DAL.Entities.Game", "Game")
                        .WithMany("GamePlatformTypes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Store.DAL.Entities.PlatformType", "PlatformType")
                        .WithMany("GamePlatformTypes")
                        .HasForeignKey("PlatformTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.DAL.Entities.Genre", b =>
                {
                    b.HasOne("Store.DAL.Entities.Genre", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Store.DAL.Entities.GenreGame", b =>
                {
                    b.HasOne("Store.DAL.Entities.Game", "Game")
                        .WithMany("GenreGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Store.DAL.Entities.Genre", "Genre")
                        .WithMany("GenreGames")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
