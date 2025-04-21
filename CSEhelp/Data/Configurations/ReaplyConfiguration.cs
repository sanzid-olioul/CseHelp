using CSEhelp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSEhelp.Data.Configurations
{
    public class ReaplyConfiguration: IEntityTypeConfiguration<Reaply>
    {
        public void Configure(EntityTypeBuilder<Reaply> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).HasColumnType("uniqueidentifier");
            builder.Property(r => r.Name).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(r => r.Email).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(r => r.Content).IsRequired().HasColumnType("nvarchar(250)");
            builder.HasOne(r => r.Comment)
                .WithMany(c => c.Reaplies)
                .HasForeignKey(r => r.CommentId);
        }
    }
}
