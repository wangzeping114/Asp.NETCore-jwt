using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class AdvertConfiguration : IEntityTypeConfiguration<Advert>
    {
        public void Configure(EntityTypeBuilder<Advert> builder)
        {
            builder.Property(p => p.ImagePath)
                .IsRequired();

            builder.Property(p => p.Alt)
                   .IsRequired(false);

            builder.Property(p => p.IsShow)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(p => p.MaxNumber);

            builder.Property(p => p.FailureAt)
               .IsRequired();

        }
    }
}
