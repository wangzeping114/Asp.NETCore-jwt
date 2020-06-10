using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class RoleMenuConfiguration : IEntityTypeConfiguration<RoleMenu>
    {
        public void Configure(EntityTypeBuilder<RoleMenu> builder)
        {
            builder.Property(p => p.Id)
                  .ValueGeneratedOnAdd();

            builder.Property(p => p.Permission)
                   .HasDefaultValue(Permission.None);

            builder.HasOne(p => p.Menu)
                .WithMany(s => s.RoleMenus)
                .HasForeignKey(sc => sc.MenuId);

            builder.HasOne(p => p.Role)
                .WithMany(s => s.RoleMenus)
                .HasForeignKey(sc => sc.RoleId);
        }
    }
}
