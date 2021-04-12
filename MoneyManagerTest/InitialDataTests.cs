using MoneyManagerModel;
using NUnit.Framework;
using System;

namespace MoneyManagerTest
{
    [TestFixture]
    public class InitialDataTests
    {
        [Test]
        public void InitialUserData()
        {
            var userCount = InitialData.Users.Count;
            Assert.AreEqual(5, userCount);

            var user = InitialData.Users[0];
            Assert.AreEqual(1, user.UserId);
            Assert.AreEqual("Clyde E. Troia", user.Name);
            Assert.AreEqual("ClydeETroia@dayrep.com", user.Email);
        }

        [Test]
        public void InitialAssetData()
        {
            var assetCount = InitialData.Assets.Count;
            Assert.AreEqual(20, assetCount);

            var asset = InitialData.Assets[0];
            Assert.AreEqual(1, asset.AssetId);
            Assert.AreEqual("Cash", asset.Name);
            Assert.AreEqual(5246, asset.Balance);
            Assert.AreEqual(1, asset.UserId);
        }

        [Test]
        public void InitialCategoryData()
        {
            var categoryCount = InitialData.Categories.Count;
            Assert.AreEqual(10, categoryCount);

            var category = InitialData.Categories[0];
            Assert.AreEqual(1, category.CategoryId);
            Assert.IsTrue(category.IsIncome);
            Assert.AreEqual("Salary", category.Name);
        }

        [Test]
        public void InitialTransactionData()
        {
            var transactionCount = InitialData.Transactions.Count;
            Assert.AreEqual(100, transactionCount);

            var transaction = InitialData.Transactions[0];
            Assert.AreEqual(1, transaction.TransactionId);
            Assert.AreEqual(56, transaction.Amount);
            Assert.AreEqual(new DateTime(2021,2,11), transaction.Date);
            Assert.AreEqual("MusicGlobal", transaction.Comment);
            Assert.AreEqual(1, transaction.CategoryId);
            Assert.AreEqual(1, transaction.AssetId);
        }
    }
}