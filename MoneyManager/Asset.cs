using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MoneyManager
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }

    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.ToTable("Assets");

            builder.HasKey(a => a.AssetId);

            builder.Property(a => a.AssetId)
                .HasColumnName("a_id")
                .ValueGeneratedOnAdd();

            builder.Property(a => a.Name)
                .HasColumnName("a_name");

            builder.Property(a => a.Balance)
                .HasColumnName("a_balance")
                .HasColumnType("decimal(10,2)");

            builder.Property(a => a.UserId)
                .HasColumnName("a_user_id");

            builder.HasOne(a => a.User)
                .WithMany(u => u.Assets);

            builder.HasMany(a => a.Transactions)
                .WithOne(t => t.Asset);
        }
    }
}
