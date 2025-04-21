using CSEhelp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSEhelp.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnType("uniqueidentifier");
            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(c => c.Email).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(c => c.Content).IsRequired().HasColumnType("nvarchar(250)");
            builder.HasOne(c => c.Article).WithMany(a => a.Comments)
                .HasForeignKey(c => c.ArticleId);
        }
    }
}
