using CSEhelp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSEhelp.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable(nameof(AppUser));
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Id).HasColumnType("uniqueidentifier");
            builder.Property(u => u.FirstName).IsRequired(true).HasColumnType("nvarchar(50)");
            builder.Property(u => u.LastName).IsRequired(true).HasColumnType("nvarchar(50)");
            builder.Property(u => u.ProfileImagePath).IsRequired(false).HasColumnType("nvarchar(256)");
        }
    }
}
