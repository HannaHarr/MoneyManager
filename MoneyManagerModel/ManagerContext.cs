﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MoneyManagerModel
{
    public class ManagerContext : DbContext
    {
        public DbSet<User> 
            Users { get; set; }
        
        public DbSet<Asset> 
            Assets { get; set; }
        
        public DbSet<Category> 
            Categories { get; set; }
        
        public DbSet<Transaction> 
            Transactions { get; set; }

        public ManagerContext(
            DbContextOptions<ManagerContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
