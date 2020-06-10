using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CommodityDetailPirtureConfiguration : IEntityTypeConfiguration<CommodityDetailPirture>
    {
        public void Configure(EntityTypeBuilder<CommodityDetailPirture> builder)
        {
            builder.Property(p => p.Path)
                   .IsRequired();

            builder.Property(p => p.Sequence)
                    .IsRequired()
                    .HasDefaultValue(1);

            builder.HasOne(h => h.CommodityDetail)
                    .WithMany(w => w.CommodityDetailPirtures)
                    .HasForeignKey(h => h.CommodityDetailId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
