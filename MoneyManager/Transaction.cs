using Microsoft.EntityFrameworkCore;
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
            builder.ToTable("Transactions");

            builder.HasKey(t => t.TransactionId);

            builder.Property(t => t.TransactionId)
                .HasColumnName("t_id")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Amount)
                .HasColumnName("t_amount")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.Date)
                .HasColumnName("t_date")
                .HasColumnType("Date");

            builder.Property(t => t.Comment)
                .HasColumnName("t_comment");

            builder.HasOne(t => t.Category)
                .WithMany(c => c.Transactions);

            builder.HasOne(t => t.Asset)
                .WithMany(a => a.Transactions);
        }
    }
}
