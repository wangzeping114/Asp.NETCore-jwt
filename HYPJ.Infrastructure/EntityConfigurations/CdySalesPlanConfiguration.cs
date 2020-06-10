using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CdySalesPlanConfiguration : IEntityTypeConfiguration<CdySalesPlan>
    {
        public void Configure(EntityTypeBuilder<CdySalesPlan> builder)
        {
            builder.Property(p => p.PlanPrice)
                .IsRequired()
                .HasColumnType("Decimal(9,2)");

            builder.Property(p => p.PlanTime)
                .IsRequired();

            builder.HasOne(p => p.Commodity)
                .WithMany(w => w.CdySalesPlans)
                .HasForeignKey(p => p.CommodityId);

        }
    }
}
