using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CommodityConfiguration : IEntityTypeConfiguration<Commodity>
    {
        public void Configure(EntityTypeBuilder<Commodity> builder)
        {
            builder.Property(p => p.TitileOrName)
                .IsRequired();

            builder.Property(p => p.SerialNumber)
                .IsRequired();

            builder.Property(p => p.CommodityStatus)
                .HasDefaultValue(CommodityStatus.上架);

            builder.Property(p => p.ImagePath)
                .IsRequired(false);

            builder.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("DECIMAL(9,2)");

            builder.Property(p => p.MarketPrice)
                .IsRequired()
                .HasColumnType("DECIMAL(9,2)");

            builder.Property(p => p.ShelfTime);

            builder.Property(p => p.CreateTime);

            builder.Property(p => p.AsOfTime);

            builder.Property(p => p.Sequence)
                  .IsRequired()
                  .HasDefaultValue(1);

            builder.HasOne(p => p.Category)
                   .WithMany(w => w.Commoditys)
                   .HasForeignKey(h => h.CategoryId);



        }
    }
}
