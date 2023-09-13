using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Contexts
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Models.Employee> Employees { get; set; }

        public DbSet<Models.Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,11433;Initial Catalog=KD-17;User ID=sa;Password=Admin123!;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Employee>().ToTable("Employees");
            modelBuilder.Entity<Models.Store>().ToTable("Stores");
        }
    }
}
