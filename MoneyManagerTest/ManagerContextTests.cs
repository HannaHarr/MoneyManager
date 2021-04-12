using MoneyManagerModel;
using NUnit.Framework;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MoneyManagerTest
{
    [TestFixture]
    class ManagerContextTests
    {
        private ManagerContext context;

        [SetUp]
        public void Setup()
        {
            context = new ManagerContext();
        }

        [Test]
        public void ManagerContextCreated()
        {
            Assert.NotNull(context);
        }

        [Test]
        public void UserCreateUpdateDelete()
        {
            var user = new User("Lohan A. Kern", "volf@rain.tr");

            EntityEntry<User> entity = context.Users.Add(user);
            Assert.AreEqual(EntityState.Added, entity.State);
            context.SaveChanges();

            user.Name = "Logan A. Kern";
            entity = context.Users.Update(user);
            Assert.AreEqual(EntityState.Modified, entity.State);
            context.SaveChanges();

            entity = context.Users.Remove(user);
            Assert.AreEqual(EntityState.Deleted, entity.State);
            context.SaveChanges();
        }

        [Test]
        public void AssetCreateUpdateDelete()
        {
            var asset = new Asset("Money", 487, 1);

            EntityEntry<Asset> entity
                = context.Assets.Add(asset);
            Assert.AreEqual(EntityState.Added, entity.State);
            context.SaveChanges();

            asset.Name = "PayPal";
            entity = context.Assets.Update(asset);
            Assert.AreEqual(EntityState.Modified, entity.State);
            context.SaveChanges();

            entity = context.Assets.Remove(asset);
            Assert.AreEqual(EntityState.Deleted, entity.State);
            context.SaveChanges();
        }

        [Test]
        public void CategoryCreateUpdateDelete()
        {
            var category = new Category(false, "Cinma");

            EntityEntry<Category> entity
                = context.Categories.Add(category);
            Assert.AreEqual(EntityState.Added, entity.State);
            context.SaveChanges();

            category.Name = "Cinema";
            entity = context.Categories.Update(category);
            Assert.AreEqual(EntityState.Modified, entity.State);
            context.SaveChanges();

            entity = context.Categories.Remove(category);
            Assert.AreEqual(EntityState.Deleted, entity.State);
            context.SaveChanges();
        }

        [Test]
        public void TransactionCreateUpdateDelete()
        {
            var transaction = new Transaction(
                33, new DateTime(), "Valley of Dreams",
                2, 2);

            EntityEntry<Transaction> entity
                = context.Transactions.Add(transaction);
            Assert.AreEqual(EntityState.Added, entity.State);
            context.SaveChanges();

            transaction.Comment = "Cinema";
            entity = context.Transactions.Update(transaction);
            Assert.AreEqual(EntityState.Modified, entity.State);
            context.SaveChanges();

            entity = context.Transactions.Remove(transaction);
            Assert.AreEqual(EntityState.Deleted, entity.State);
            context.SaveChanges();
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void GetUserById(int id)
        {
            var user = context.Users
                .Where(u => u.UserId == id)
                .FirstOrDefault();

            Assert.NotNull(user);
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(20)]
        public void GetAssetById(int id)
        {
            var asset = context.Assets
                .Where(a => a.AssetId == id)
                .FirstOrDefault();

            Assert.NotNull(asset);
        }

        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void GetCategoryById(int id)
        {
            var category = context.Categories
                .Where(c => c.CategoryId == id)
                .FirstOrDefault();

            Assert.NotNull(category);
        }

        [TestCase(1)]
        [TestCase(50)]
        [TestCase(100)]
        public void GetTransactionById(int id)
        {
            var transaction = context.Transactions
                .Where(t => t.TransactionId == id)
                .FirstOrDefault();

            Assert.NotNull(transaction);
        }

        [TestCase("ClydeETroia@dayrep.com")]
        [TestCase("RichardNParsons@dayrep.com")]
        [TestCase("LauraJBancroft@rhyta.com")]
        public void GetUserByEmail(string email)
        {
            var user = context.Users
                .Where(u => u.Email == email)
                .FirstOrDefault();

            Assert.NotNull(user);
        }

        [TestCase(2)]
        [TestCase(4)]
        public void DeleteUsersTransactions(int id)
        {
            var transactions = context.Transactions
                .Where(t => (t.Asset.UserId == id &&
                t.Date.Year == DateTime.Now.Year &&
                t.Date.Month == DateTime.Now.Month))
                .ToList();

            Assert.NotNull(transactions);

            context.Transactions.RemoveRange(transactions);
            context.SaveChanges();
        }

        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }
    }
}
