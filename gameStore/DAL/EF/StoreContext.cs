using Microsoft.EntityFrameworkCore;
using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.DAL.EF
{
    public class StoreContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PlatformType> PlatformTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public StoreContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=gameStore;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>()
            .HasAlternateKey(p => p.Name);

            modelBuilder.Entity<Genre>()
            .HasAlternateKey(g => g.Name);

            modelBuilder.Entity<PlatformType>()
            .HasAlternateKey(p => p.Type);


            modelBuilder.Entity<GenreGame>()
            .HasKey(gg => new { gg.GenreId, gg.GameId });

            modelBuilder.Entity<GenreGame>()
                .HasOne(gg => gg.Genre)
                .WithMany(g => g.GenreGames)
                .HasForeignKey(gg => gg.GenreId);

            modelBuilder.Entity<GenreGame>()
                .HasOne(gg => gg.Game)
                .WithMany(g => g.GenreGames)
                .HasForeignKey(gg => gg.GameId);

            modelBuilder.Entity<GamePlatformType>()
            .HasKey(gp => new { gp.GameId, gp.PlatformTypeId });

            modelBuilder.Entity<GamePlatformType>()
                .HasOne(gp => gp.Game)
                .WithMany(g => g.GamePlatformTypes)
                .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GamePlatformType>()
                .HasOne(gp => gp.PlatformType)
                .WithMany(p => p.GamePlatformTypes)
                .HasForeignKey(gp => gp.PlatformTypeId);
        }


    }
}
