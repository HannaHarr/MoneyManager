using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyManagerModel.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 1, true, "Salary", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 2, true, "Bonus", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 3, true, "Petty cash", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 4, false, "Food", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 5, false, "Social Life", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 6, false, "Self-development", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 7, false, "Culture", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 8, false, "Transportation", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name" },
                values: new object[] { 1, "ClydeETroia@dayrep.com", "Clyde E. Troia" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name" },
                values: new object[] { 2, "DanielDFleischer@armyspy.com", "Daniel D. Fleischer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name" },
                values: new object[] { 3, "RichardNParsons@dayrep.com", "Richard N. Parsons" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name" },
                values: new object[] { 4, "JamesLPonce@teleworm.us", "James L. Ponce" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Name" },
                values: new object[] { 5, "LauraJBancroft@rhyta.com", "Laura J. Bancroft" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 9, 6575, "Cash", 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 18, 2566, "Debit cards", 5 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 17, 56, "Cash", 5 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 16, 31645, "Loan", 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 15, 87986, "Bank account", 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 14, 3526, "Loan", 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 13, 2656, "Cash", 4 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 12, 25778, "Bank account", 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 11, 8945, "Bank account", 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 10, 165, "Debit cards", 3 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 20, 8787, "Loan", 5 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 8, 230495, "Loan", 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 7, 568, "Bank account", 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 6, 987, "Debit cards", 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 5, 8974, "Cash", 2 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 4, 7846, "Loan", 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 3, 7854, "Bank account", 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 2, 87, "Debit cards", 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 1, 5246, "Cash", 1 });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "AssetId", "Balance", "Name", "UserId" },
                values: new object[] { 19, 5254, "Bank account", 5 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 10, false, "Taxi", 8 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsIncome", "Name", "ParentId" },
                values: new object[] { 9, false, "Public transport", 8 });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 1, 56m, 1, 1, "MusicGlobal", new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 28, 290m, 8, 3, "ChefMusic", new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 18, 168m, 8, 2, "ChefMusic", new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 8, 992m, 8, 1, "Rokataron", new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 97, 789m, 7, 10, "MatCoast", new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 87, 474m, 7, 9, "Larokata", new DateTime(2020, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 77, 499m, 7, 8, "MatCoast", new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 67, 269m, 7, 7, "KnightForward", new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 57, 766m, 7, 6, "Phamiron", new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 47, 673m, 7, 5, "Rokataron", new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 37, 752m, 7, 4, "KnightForward", new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 27, 670m, 7, 3, "Carouselot", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 17, 977m, 7, 2, "ElementSquare", new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 7, 547m, 7, 1, "Tonlaron", new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 96, 639m, 6, 10, "Tonlaron", new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 86, 1621m, 6, 9, "Carouselot", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 76, 551m, 6, 8, "MatCoast", new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 66, 753m, 6, 7, "RobustArrakis", new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 56, 420m, 6, 6, "Larokata", new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 46, 838m, 6, 5, "Carouselot", new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 36, 821m, 6, 4, "ElementSquare", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 26, 208m, 6, 3, "SundayTops", new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 38, 592m, 8, 4, "SundayTops", new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 16, 108m, 6, 2, "Tonlaron", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 48, 533m, 8, 5, "Tonlaron", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 68, 612m, 8, 7, "Tonlaron", new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 80, 24m, 10, 8, "SundayTops", new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 70, 175m, 10, 7, "SundayTops", new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 60, 599m, 10, 6, "Tonlaron", new DateTime(2020, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 50, 184m, 10, 5, "Larokata", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 40, 902m, 10, 4, "ChefMusic", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 30, 533m, 10, 3, "Rokataron", new DateTime(2020, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 20, 388m, 10, 2, "Carouselot", new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 10, 565m, 10, 1, "SnowflakesGem", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 99, 1123m, 9, 10, "ElementSquare", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 89, 170m, 9, 9, "Tonlaron", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 79, 132m, 9, 8, "TheaterCompass", new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 69, 461m, 9, 7, "RobustArrakis", new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 59, 609m, 9, 6, "ChefMusic", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 49, 299m, 9, 5, "SundayTops", new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 39, 693m, 9, 4, "SnowflakesGem", new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 29, 668m, 9, 3, "TheaterCompass", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 19, 294m, 9, 2, "SundayTops", new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 9, 23m, 9, 1, "Ronpha", new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 98, 706m, 8, 10, "Phamiron", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 88, 519m, 8, 9, "TheaterCompass", new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 78, 989m, 8, 8, "ChefMusic", new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 58, 625m, 8, 6, "KnightForward", new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 6, 521m, 6, 1, "SundayTops", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 95, 1166m, 5, 10, "TheaterCompass", new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 85, 1839m, 5, 9, "Phamiron", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 13, 126m, 3, 2, "SundayTops", new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 3, 77m, 3, 1, "DollGlobal", new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 92, 146m, 2, 10, "KnightForward", new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 82, 186m, 2, 9, "ChefMusic", new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 72, 773m, 2, 8, "Larokata", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 62, 880m, 2, 7, "Rokataron", new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 52, 614m, 2, 6, "RobustArrakis", new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 42, 32m, 2, 5, "Phamiron", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 32, 889m, 2, 4, "Tonlaron", new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 22, 539m, 2, 3, "TheaterCompass", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 12, 448m, 2, 2, "Carouselot", new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 2, 14m, 2, 1, "ElementSquare", new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 91, 1290m, 1, 10, "SundayTops", new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 81, 788m, 1, 9, "KnightForward", new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 71, 40m, 1, 8, "ElementSquare", new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 61, 972m, 1, 7, "ElementSquare", new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 51, 355m, 1, 6, "Phamiron", new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 41, 214m, 1, 5, "Tonlaron", new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 31, 969m, 1, 4, "Carouselot", new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 21, 864m, 1, 3, "Rokataron", new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 11, 54m, 1, 2, "TheaterCompass", new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 23, 187m, 3, 3, "SnowflakesGem", new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 33, 819m, 3, 4, "SnowflakesGem", new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 43, 579m, 3, 5, "Larokata", new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 53, 442m, 3, 6, "Carouselot", new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 75, 703m, 5, 8, "Tonlaron", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 65, 651m, 5, 7, "SnowflakesGem", new DateTime(2020, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 55, 264m, 5, 6, "Tonlaron", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 45, 554m, 5, 5, "RobustArrakis", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 35, 136m, 5, 4, "Tonlaron", new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 25, 967m, 5, 3, "Tonlaron", new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 15, 231m, 5, 2, "TheaterCompass", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 5, 439m, 5, 1, "ChefMusic", new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 94, 298m, 4, 10, "ChefMusic", new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 84, 465m, 4, 9, "SnowflakesGem", new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 90, 1129m, 10, 9, "Carouselot", new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 74, 674m, 4, 8, "KnightForward", new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 54, 955m, 4, 6, "ElementSquare", new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 44, 305m, 4, 5, "RobustArrakis", new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 34, 127m, 4, 4, "KnightForward", new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 24, 815m, 4, 3, "ElementSquare", new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 14, 843m, 4, 2, "KnightForward", new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 4, 90m, 4, 1, "PrioritySquare", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 93, 1273m, 3, 10, "Rokataron", new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 83, 635m, 3, 9, "Tonlaron", new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 73, 259m, 3, 8, "Rokataron", new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 63, 356m, 3, 7, "SundayTops", new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 64, 210m, 4, 7, "TheaterCompass", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "Amount", "AssetId", "CategoryId", "Comment", "Date" },
                values: new object[] { 100, 160m, 10, 10, "SnowflakesGem", new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "AssetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
