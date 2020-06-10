using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CdyThelabelCommoditiesConfiguration : IEntityTypeConfiguration<CdyThelabelCommodity>
    {
        public void Configure(EntityTypeBuilder<CdyThelabelCommodity> builder)
        {
            builder.Property(p => p.Id)
            .ValueGeneratedOnAdd();

            builder.HasKey(p => new { p.CommdityId, p.CdyThelabelId });

            builder.HasOne(e => e.CdyThelabel)
                .WithMany(w => w.CdyThelabelCommodities)
                .HasForeignKey(h => h.CdyThelabelId);

            builder.HasOne(e => e.Commodity)
                .WithMany(w => w.CdyThelabelCommodities)
                .HasForeignKey(h => h.CommdityId);
        }
    }
}
