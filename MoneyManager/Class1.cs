using Microsoft.EntityFrameworkCore;
using System;

namespace MoneyManager
{
    public class ManagerContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Asset> Assets { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Transaction> Transactions { get; set; }
    }

    public class User
    {

    }

    public class Asset
    {

    }

    public class Category
    {

    }

    public class Transaction
    {

    }
}
