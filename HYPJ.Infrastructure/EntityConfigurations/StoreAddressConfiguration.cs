using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class StoreAddressConfiguration : IEntityTypeConfiguration<StoreAddress>
    {
        public void Configure(EntityTypeBuilder<StoreAddress> builder)
        {
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.HasOne(p => p.Address)
                    .WithOne(w => w.StoreAddress)
                    .HasForeignKey<StoreAddress>(h => h.AddressId);

            builder.HasOne(p => p.Store)
                .WithOne(w => w.StoreAddress)
                .HasPrincipalKey<StoreAddress>(sc => sc.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
