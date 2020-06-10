using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CdyThelabelConfiguration : IEntityTypeConfiguration<CdyThelabel>
    {
        public void Configure(EntityTypeBuilder<CdyThelabel> builder)
        {
            builder.Property(p => p.Type)
                   .IsRequired();

        }
    }
}
