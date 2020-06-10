using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class OrderAddressConfiguration : IEntityTypeConfiguration<OrderAddress>
    {
        public void Configure(EntityTypeBuilder<OrderAddress> builder)
        {
            builder.Property(p => p.ContactName)
                .IsRequired();

            builder.Property(p => p.Phone)
                   .IsRequired();

            builder.Property(p => p.ZipCode)
                .IsRequired(false);

            builder.Property(p => p.AddressLine)
                    .IsRequired(false);

            builder.HasOne(p => p.Order)
                   .WithOne(w => w.OrderAddress)
                   .HasForeignKey<OrderAddress>(h => h.OrderId);

            builder.HasOne(p => p.Address)
                    .WithOne(w => w.OrderAddress)
                    .HasForeignKey<OrderAddress>(h => h.AddressId);
        }
    }
}
