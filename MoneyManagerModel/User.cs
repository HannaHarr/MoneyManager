using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MoneyManagerModel
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        // public decimal Balance { get; set; }

        public ICollection<Asset> Assets { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.UserId)
                .ValueGeneratedOnAdd();

            builder.HasMany(u => u.Assets)
                .WithOne(a => a.User);

            builder.HasData(InitialData.Users);
        }
    }
}
