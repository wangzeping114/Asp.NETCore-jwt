using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CommodityDetailConfiguration : IEntityTypeConfiguration<CommodityDetail>
    {
        public void Configure(EntityTypeBuilder<CommodityDetail> builder)
        {
            builder.Property(p => p.ActivityAddressDescription)
                .IsRequired();

            builder.Property(p => p.ActivityTimeDescription)
                .IsRequired();

            builder.Property(p => p.NeedKnowPath)
                .IsRequired();

            builder.Property(p => p.DetailPath)
               .IsRequired();

            builder.HasOne(p => p.Commodity)
                   .WithOne(w => w.CommodityDetail)
                   .HasForeignKey<CommodityDetail>(h => h.CommodityId)
                   .OnDelete(DeleteBehavior.Restrict);





        }
    }
}
