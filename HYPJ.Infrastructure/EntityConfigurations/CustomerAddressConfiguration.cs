using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {

            builder.Property(p => p.CreateOn)
                .IsRequired();

            builder.HasOne(p => p.Customer)
                .WithMany(w => w.CustomerAddress)
                .HasForeignKey(h => h.CustomerId);

            builder.HasOne(p => p.Address)
                .WithOne(w => w.CustomerAddress)
                .HasForeignKey<CustomerAddress>(h => h.AddressId);


        }
    }
}
