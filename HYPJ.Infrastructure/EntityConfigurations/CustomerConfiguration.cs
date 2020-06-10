using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.Phone)
                .IsRequired();

            builder.Property(p => p.Password)
                .IsRequired();

            builder.Property(p => p.Salt)
                .IsRequired();

            builder.Property(p => p.CreateOn)
                .IsRequired();

            builder.Property(p => p.LastOn)
                .IsRequired();

            builder.Property(p => p.DefaultBillingAddressId);

            builder.Ignore(p => p.DefaultBillingAddress);

        }
    }
}
