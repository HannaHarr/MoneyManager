using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MoneyManager
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public ICollection<Asset> Assets { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.UserId);

            builder.Property(u => u.UserId)
                .HasColumnName("u_id")
                .ValueGeneratedOnAdd();

            builder.Property(u => u.Balance)
                .HasColumnName("u_balance")
                .HasColumnType("decimal(10,2)");

            builder.Property(u => u.Name)
                .HasColumnName("u_name");

            builder.Property(u => u.Email)
                .HasColumnName("u_email");

            builder.HasMany(u => u.Assets)
                .WithOne(a => a.User);
        }
    }
}
