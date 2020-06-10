using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CdySmallestUnitConfiguration : IEntityTypeConfiguration<CdySmallestUnit>
    {
        public void Configure(EntityTypeBuilder<CdySmallestUnit> builder)
        {
            builder.Property(p => p.UnitType)
                .IsRequired();
        }
    }
}
