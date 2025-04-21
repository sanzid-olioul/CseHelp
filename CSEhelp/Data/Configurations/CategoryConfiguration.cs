using CSEhelp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSEhelp.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnType("uniqueidentifier");
            builder.Property(c => c.Name).IsRequired(true).HasColumnType("nvarchar(50)");
            builder.Property(c => c.Description).IsRequired(false).HasColumnType("nvarchar(250)");
        }
    }
}
