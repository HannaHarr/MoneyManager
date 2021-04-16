using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                   .AddJsonFile("setting.json");

            var config = builder.Build();

            string connString = config.GetConnectionString("DefaultConnection");

            connString = string.Format(connString, AppDomain.CurrentDomain.BaseDirectory);

            optionsBuilder.UseSqlite(connString);
        }

        public ManagerContext() { }

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
