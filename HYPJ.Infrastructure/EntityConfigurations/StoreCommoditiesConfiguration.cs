using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class StoreCommoditiesConfiguration : IEntityTypeConfiguration<StoreCommodities>
    {
        public void Configure(EntityTypeBuilder<StoreCommodities> builder)
        {
            builder.Property(p => p.Id)
            .ValueGeneratedOnAdd();

            builder.HasKey(p => new { p.CommodityId, p.StoreId });

            builder.HasOne(p => p.Store)
                .WithMany(w => w.StoreCommodities)
                .HasForeignKey(p => p.StoreId);

            builder.HasOne(p => p.Commodity)
                .WithMany(w => w.StoreCommodities)
                .HasForeignKey(p => p.CommodityId);
        }
    }
}
