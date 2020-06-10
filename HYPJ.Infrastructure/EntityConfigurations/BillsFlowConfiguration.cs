using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class BillsFlowConfiguration : IEntityTypeConfiguration<BillsFlow>
    {
        public void Configure(EntityTypeBuilder<BillsFlow> builder)
        {
            builder.Property(p => p.BillsStatus)
                .IsRequired()
                .HasDefaultValue(BillsStatus.未下拨);

            builder.HasOne(p => p.PaymentRecord)
                .WithOne(w => w.BillsFlow)
                .HasForeignKey<BillsFlow>(h => h.PaymentRecordId);

            builder.HasOne(p => p.Account)
                    .WithMany(w => w.BillsFlows)
                    .HasForeignKey(h => h.AccountId);
        }
    }
}
