﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MoneyManagerModel
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public Asset(string name, int balance, int userId)
        {
            Name = name;
            Balance = balance;
            UserId = userId;
        }

        public Asset() { }
    }

    public class AssetConfiguration 
        : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.Property(a => a.AssetId)
                .ValueGeneratedOnAdd();

            builder.HasOne(a => a.User)
                .WithMany(u => u.Assets);

            builder.HasMany(a => a.Transactions)
                .WithOne(t => t.Asset);

            builder.HasData(InitialData.Assets);
        }
    }
}
