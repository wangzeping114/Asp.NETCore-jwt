using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CdySmallestUnitCommoditiesConfiguration : IEntityTypeConfiguration<CdySmallestUnitCommodities>
    {
        public void Configure(EntityTypeBuilder<CdySmallestUnitCommodities> builder)
        {
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.HasKey(p => new { p.CommodityId, p.CdySamllestUnitId });

            builder.HasOne(p => p.CdySmallestUnit)
                    .WithMany(e => e.CdySmallestUnitCommodities)
                    .HasForeignKey(sc => sc.CdySamllestUnitId);

            builder.HasOne(p => p.Commodity)
                .WithMany(e => e.CdySmallestUnitCommodities)
                .HasForeignKey(sc => sc.CommodityId);
        }
    }
}
