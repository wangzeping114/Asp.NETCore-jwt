using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasColumnType("NVARCHAR(32)");

            builder.Property(p => p.IsSuperAdmin).IsRequired().HasDefaultValue(false);

            builder.Property(p => p.Description).IsRequired(false);

        }
    }
}
