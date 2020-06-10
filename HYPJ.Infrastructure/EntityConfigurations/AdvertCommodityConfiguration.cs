using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class AdvertCommodityConfiguration : IEntityTypeConfiguration<AdvertCommodity>
    {
        public void Configure(EntityTypeBuilder<AdvertCommodity> builder)
        {
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.HasKey(e => new { e.AdvertId, e.CommodityId });

            builder.HasOne(e => e.Advert)
                .WithMany(w => w.AdvertCommodities)
                .HasForeignKey(sc => sc.AdvertId);

            builder.HasOne(e => e.Commodity)
                .WithMany(w => w.AdvertCommodities)
                .HasForeignKey(sc => sc.CommodityId);

        }
    }
}
