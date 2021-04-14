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

        [Test]
        public void DeleteUsersTransactions()
        {
            var id = 1;

            var transaction = new Transaction(
                33, DateTime.Now, "Valley of Dreams",
                2, 2);
            EntityEntry<Transaction> entity
                = context.Transactions.Add(transaction);
            Assert.AreEqual(EntityState.Added, entity.State);
            context.SaveChanges();

            var transactions = context.Transactions
                .Where(t => (t.Asset.UserId == id &&
                t.Date.Year == DateTime.Now.Year &&
                t.Date.Month == DateTime.Now.Month))
                .ToList();

            Assert.NotNull(transactions);
            Assert.GreaterOrEqual(transactions.Count, 1);

            foreach (var trans in transactions)
            {
                entity = context.Transactions.Remove(trans);
                Assert.AreEqual(EntityState.Deleted, entity.State);
            }

            context.SaveChanges();
        }

        [Test]
        public void GetUserList()
        {
            var users = (from user 
                         in context.Users
                         orderby user.Name
                         select new
                         {
                             user.UserId,
                             user.Name,
                             user.Email
                         }).ToList();

            Assert.NotNull(users);
            Assert.GreaterOrEqual(users.Count, 5);
            Assert.AreEqual(1, users[0].UserId);
            Assert.AreEqual("Clyde E. Troia", users[0].Name);
            Assert.AreEqual("ClydeETroia@dayrep.com", users[0].Email);
        }

        [Test]
        public void GetCurrentBalance()
        {
            var id = 1;

            var user = (from u
                        in context.Users
                        where u.UserId == id
                        select new
                        {
                            u.UserId,
                            u.Name,
                            u.Email,
                            Balance = u.Assets
                            .Sum(a => a.Balance)

                        }).FirstOrDefault();

            Assert.NotNull(user);
            Assert.AreEqual("Clyde E. Troia", user.Name);
            Assert.AreEqual("ClydeETroia@dayrep.com", user.Email);
            Assert.AreEqual(21033, user.Balance);
        }

        [Test]
        public void GetUserAssets()
        {
            var id = 1;

            var assets = (from a 
                          in context.Assets
                          where a.UserId == id
                          orderby a.Name
                          select new
                          {
                              a.AssetId,
                              a.Name,
                              a.Balance
                          }).ToList();

            Assert.NotNull(assets);
            Assert.GreaterOrEqual(assets.Count, 4);
            Assert.AreEqual(3, assets[0].AssetId);
            Assert.AreEqual("Bank account", assets[0].Name);
            Assert.AreEqual(7854, assets[0].Balance);
        }

        [Test]
        public void GetUserTransactions()
        {
            var id = 1;

            var transactions = (from t
                               in context.Transactions
                               where t.Asset.UserId == id
                               orderby t.Date descending, 
                                       t.Asset.Name, 
                                       t.Category.Name
                               select new
                               {
                                   t.TransactionId,
                                   Asset = t.Asset.Name,
                                   Category = t.Category.Name,
                                   ParentCategory = t.Category.Parent.Name,
                                   t.Amount,
                                   t.Date,
                                   t.Comment
                               }).ToList();

            Assert.NotNull(transactions);
            Assert.GreaterOrEqual(transactions.Count, 20);
            Assert.AreEqual("Debit cards", transactions[0].Asset);
            Assert.AreEqual("Salary", transactions[0].Category);
            Assert.AreEqual(null, transactions[0].ParentCategory);
            Assert.AreEqual(14, transactions[0].Amount);
            Assert.AreEqual(new DateTime(2021, 2, 17), transactions[0].Date);
            Assert.AreEqual("ElementSquare", transactions[0].Comment);
        }

        [Test]
        public void GetTotalValue()
        {
            var id = 1;
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2021, 1, 1);

            
            var money = (from t
                         in context.Transactions
                         where ((t.Asset.UserId == id)
                               && (t.Date > startDate) 
                               && (t.Date < endDate))
                         orderby t.Date
                         group t by t.Date.Month into g
                         select new
                         {
                             Month = g.Key,
                             List = g.ToList(),

                             //Income = (from o
                             //          in obj
                             //          where o.Category.IsIncome
                             //          select o)
                             //          .AsEnumerable()
                             //          .Sum(o => o.Amount),

                             //Income = obj
                             //.Select(o => o)
                             //.Where(o => o.Category.IsIncome)
                             //.Sum(o => o.Amount),

                             //Expenses = obj
                             //.Select(o => o)
                             //.Where(o => !o.Category.IsIncome)
                             //.Sum(o => o.Amount),


                         }).ToList();
            

            Assert.NotNull(money);
            Assert.GreaterOrEqual(money.Count, 9);
            Assert.AreEqual(3, money[0].Month);
            //Assert.AreEqual(2020, money[0].Year);
            //Assert.AreEqual(0, money[0].Income);
            //Assert.AreEqual(214 + 465, money[0].Expenses);
        }

        [Test]
        public void GetTotalAmount()
        {
            var id = 1;
            var isIncome = false;

            var amount = (from t
                          in context.Transactions
                          where ((t.Asset.UserId == id)
                          && (t.Category.IsIncome == isIncome)
                          && (t.Category.ParentId == null)
                          && (t.Date.Year == DateTime.Now.Year)
                          && (t.Date.Month == DateTime.Now.Month))
                          group t by t.Category into g
                          select new
                          {
                              Category = g.Key.Name,
                              //Amount = g.Sum(o => o.Amount)

                          })
                          //.OrderByDescending(obj => obj.Amount)
                          //.ThenBy(obj => obj.Category)
                          .ToList();

            Assert.NotNull(amount);
            Assert.GreaterOrEqual(amount.Count, 1);
        }

        [TearDown]
        public void TearDown()
        {
            context.Dispose();
        }
    }
}
