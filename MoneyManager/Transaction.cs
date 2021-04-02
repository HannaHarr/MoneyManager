﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MoneyManager
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AssetId { get; set; }
        public Asset Asset { get; set; }
    }

    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(t => t.TransactionId)
                .ValueGeneratedOnAdd();

            builder.HasOne(t => t.Category)
                .WithMany(c => c.Transactions);

            builder.HasOne(t => t.Asset)
                .WithMany(a => a.Transactions);
        }
    }
}
