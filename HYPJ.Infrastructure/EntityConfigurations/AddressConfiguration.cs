using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(p => p.Country)
                    .IsRequired(false);

            builder.Property(p => p.CountryCode)
                    .IsRequired(false);

            builder.Property(p => p.Province)
                    .IsRequired();

            builder.Property(p => p.ProvinceCode)
                    .IsRequired();

            builder.Property(p => p.City)
                    .IsRequired();

            builder.Property(p => p.CityCode)
                    .IsRequired();

            builder.Property(p => p.District)
                    .IsRequired();

            builder.Property(p => p.DistrictCode)
                    .IsRequired();

            builder.Property(p => p.Detail)
                   .IsRequired();

        }
    }
}
