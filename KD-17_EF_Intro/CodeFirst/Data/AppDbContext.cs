using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Host=localhost;Port=55432;Database=KD-17-Postgres;Username=postgres;Password=Admin123!")/*.LogTo(Console.WriteLine)*/;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed undefined category
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Undefined" });

            // Default product category to 1 undefined
            modelBuilder.Entity<Product>().Property(r => r.CategoryId).HasDefaultValue(1);
        }
    }
}
