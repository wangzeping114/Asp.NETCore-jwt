using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class PaymentRecordConfiguration : IEntityTypeConfiguration<PaymentRecord>
    {
        public void Configure(EntityTypeBuilder<PaymentRecord> builder)
        {
            builder.Property(p => p.PaymentSerialNumber)
                .IsRequired();

            builder.Property(p => p.PaymentType)
                .IsRequired()
                .HasDefaultValue(PaymentType.WeChat);

            builder.HasOne(p => p.Order)
                   .WithMany(w => w.PaymentRecords)
                   .HasForeignKey(h => h.OrderId);

        }
    }
}
