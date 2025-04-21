using CSEhelp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSEhelp.Data.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a  => a.Id);
            builder.Property(a => a.Id).HasColumnType("uniqueidentifier");
            builder.Property(a => a.Title).IsRequired(true)
                .HasColumnType("nvarchar(350)");
            builder.Property(a => a.Content).IsRequired(true)
                .HasColumnType("text");
            builder.Property(a => a.CreatedAt).HasColumnType("datetime");
            builder.HasOne(a => a.Author)
                .WithMany()
                .HasForeignKey(a => a.AuthorId);
        }
    }
}
