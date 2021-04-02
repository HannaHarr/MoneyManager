using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MoneyManager
{
    public class Category
    {
        public int CategoryId { get; set; }
        public bool Type { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }
        public Category Parent { get; set; }
        public ICollection<Category> Children { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryId)
                .HasColumnName("c_id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .HasColumnName("c_name");

            builder.Property(c => c.Type)
                .HasColumnName("c_type");

            builder.HasOne(c => c.Parent)
                .WithMany(c => c.Children);

            builder.HasMany(c => c.Transactions)
                .WithOne(t => t.Category);
        }
    }
}
