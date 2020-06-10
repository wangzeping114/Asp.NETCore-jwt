using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(p => p.Quantity)
                    .IsRequired()
                    .HasDefaultValue(1);

            builder.Property(p => p.ReservedQuantity)
                     .IsRequired()
                     .HasDefaultValue(0);

            builder.Property(p => p.HaveSalesQuantity)
                    .IsRequired()
                    .HasDefaultValue(0);

            builder.HasOne(p => p.Commodity)
                   .WithOne(w => w.Stock)
                   .HasForeignKey<Stock>(h => h.CommodityId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
