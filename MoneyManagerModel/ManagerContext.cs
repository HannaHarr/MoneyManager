using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MoneyManagerModel
{
    public class ManagerContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Asset> Assets { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
