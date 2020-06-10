using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class SetMealConfiguration : IEntityTypeConfiguration<SetMeal>
    {
        public void Configure(EntityTypeBuilder<SetMeal> builder)
        {
            builder.Property(p => p.Title)
                .IsRequired();

            builder.Property(p => p.Description)
                    .IsRequired(false);

            builder.Property(p => p.Price)
                    .IsRequired()
                    .HasColumnType("DECIMAL(9,2)");

            builder.Property(p => p.MarketPrice)
                .IsRequired()
                .HasColumnType("DECIMAL(9,2)");


        }
    }
}
