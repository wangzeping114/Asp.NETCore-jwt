using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.Property(p => p.Name)
                   .IsRequired();

            builder.Property(p => p.BusinessTime)
                .IsRequired();

            builder.Property(p => p.BusinessLicense)
                   .IsRequired(false);

            builder.Property(p => p.LegalPerson)
                   .IsRequired();

            builder.Property(p => p.Longitude)
                    .IsRequired(false);

            builder.Property(p => p.Latitude)
                   .IsRequired(false);


            builder.HasOne(p => p.StoreAddress)
                .WithOne(w => w.Store)
                .HasForeignKey<StoreAddress>(h => h.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.MerchantInfo)
                    .WithMany(w => w.Stores)
                    .HasForeignKey(p => p.MerchantId);


        }
    }
}
