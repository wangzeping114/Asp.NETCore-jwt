using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class WxCustomerConfiguration : IEntityTypeConfiguration<WxCustomer>
    {
        public void Configure(EntityTypeBuilder<WxCustomer> builder)
        {
            builder.Property(p => p.OpenId)
                    .IsRequired();

            builder.Property(p => p.Avtar)
                .IsRequired(false);

            builder.Property(p => p.NickName)
                .IsRequired(false);

            builder.Property(p => p.Country)
                .IsRequired(false);

            builder.Property(p => p.Province)
                .IsRequired(false);

            builder.Property(p => p.City)
                .IsRequired(false);

            builder.Property(p => p.GenderType)
                .IsRequired()
                .HasDefaultValue(GenderType.Unknown);

            builder.Property(p => p.CreateTime)
                .IsRequired();

            builder.HasOne(h => h.Customer)
                    .WithOne(w => w.WxCustomer)
                    .HasForeignKey<WxCustomer>(h => h.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
