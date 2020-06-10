using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CdyDThelabelCommodityDetailConfiguration : IEntityTypeConfiguration<CdyDThelabelCommodityDetail>
    {
        public void Configure(EntityTypeBuilder<CdyDThelabelCommodityDetail> builder)
        {
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.HasKey(p => new { p.CdyDThelabelId, p.CommodityDetailId });

            builder.HasOne(p => p.CommodityDetail)
                .WithMany(w => w.CdyDThelabelCommodityDetails)
                .HasForeignKey(sc => sc.CommodityDetailId);

            builder.HasOne(p => p.CdyDThelabel)
                .WithMany(w => w.CdyDThelabelCommodityDetails)
                .HasForeignKey(sc => sc.CdyDThelabelId);

        }
    }
}
