using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.OrderSerialNumber)
                    .IsRequired();

            builder.Property(p => p.LatestUpdatedOn)
                    .IsRequired();

            builder.Property(p => p.CreatedOn)
                    .IsRequired();

            builder.Property(p => p.SubTotal)
                    .IsRequired()
                    .HasColumnType("Decimal(9,2)");

            builder.Property(p => p.OrderTotal)
                    .IsRequired()
                    .HasColumnType("Decimal(9,2)");

            builder.Property(p => p.OrderCount)
                    .IsRequired()
                    .HasDefaultValue(0);

            builder.Property(p => p.TitileOrName)
                    .IsRequired();

            builder.Property(p => p.CommoditySerialNumber)
                    .IsRequired();

            builder.Property(p => p.Contact)
                    .IsRequired();

            builder.Property(p => p.Phone)
                .IsRequired();

            builder.Property(p => p.OrderStatus)
                .IsRequired()
                .HasDefaultValue(OrderStatus.新订单);

            builder.HasOne(p => p.Customer)
                    .WithMany(w => w.Orders)
                    .HasForeignKey(h => h.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
