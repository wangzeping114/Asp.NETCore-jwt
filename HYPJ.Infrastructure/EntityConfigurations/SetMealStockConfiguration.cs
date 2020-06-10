using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class SetMealStockConfiguration : IEntityTypeConfiguration<SetMealStock>
    {
        public void Configure(EntityTypeBuilder<SetMealStock> builder)
        {
            builder.Property(p => p.Quantity)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(p => p.ReservedQuantity)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(p => p.HaveSalesQuantity)
                .IsRequired()
                .HasDefaultValue(0);

            builder.HasOne(p => p.SetMeal)
                    .WithOne(w => w.SetMealStock)
                   .HasForeignKey<SetMealStock>(h => h.SetMealId);

        }
    }
}
