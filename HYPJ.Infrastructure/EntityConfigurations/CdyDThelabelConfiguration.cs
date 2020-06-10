using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CdyDThelabelConfiguration : IEntityTypeConfiguration<CdyDThelabel>
    {
        public void Configure(EntityTypeBuilder<CdyDThelabel> builder)
        {
            builder.Property(p => p.TheLabel)
                .IsRequired();
        }
    }
}
