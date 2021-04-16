using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MoneyManagerModel
{
    public class Category
    {
        public int CategoryId { get; set; }

        public bool IsIncome { get; set; }

        public string Name { get; set; }

        public int Color { get; set; }

        public int? ParentId { get; set; }

        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public Category()
        {
            Color = 2309453;
        }

        public Category(bool isIncome, string name)
        {
            IsIncome = isIncome;
            Name = name;
            Color = 2309453;
        }

        public Category(bool isIncome, string name, int parentId)
        {
            IsIncome = isIncome;
            Name = name;
            ParentId = parentId;
            Color = 2309453;
        }

        public Category(bool isIncome, string name, int parentId, int color)
        {
            IsIncome = isIncome;
            Name = name;
            ParentId = parentId;
            Color = color;
        }
    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.CategoryId)
                .ValueGeneratedOnAdd();

            builder.HasOne(c => c.Parent)
                .WithMany(c => c.Children);

            builder.HasMany(c => c.Transactions)
                .WithOne(t => t.Category);

            builder.Property(c => c.Color)
                .IsRequired()
                .HasDefaultValue(2309453);

            builder.HasData(InitialData.Categories);
        }
    }
}
