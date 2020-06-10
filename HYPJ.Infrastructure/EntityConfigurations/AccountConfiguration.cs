using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.FullName).IsRequired();
            builder.Property(p => p.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.LatestUpdatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.Password).IsRequired();
            builder.Property(P => P.Salt).IsRequired();
            builder.Property(p => p.IsDisplay).IsRequired();

            builder.Property(p => p.BirthOn);
            builder.Property(p => p.Phone).IsRequired(false);
            builder.Property(p => p.Avatar).IsRequired(false);
            builder.HasOne(m => m.Role)
                .WithMany(role => role.AccountModels)
                .HasForeignKey(m => m.RoleId);
        }
    }
}
