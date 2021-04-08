using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace MoneyManagerModel
{
    public class ManagerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ManagerContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@$"Data Source={Environment.CurrentDirectory}\moneymanager.db");
            // "Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;"
        }
    }
}
