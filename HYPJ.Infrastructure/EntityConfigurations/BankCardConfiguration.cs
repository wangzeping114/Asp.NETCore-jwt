using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class BankCardConfiguration : IEntityTypeConfiguration<BankCard>
    {
        public void Configure(EntityTypeBuilder<BankCard> builder)
        {
            builder.Property(p => p.OpeningBank)
                .IsRequired();

            builder.Property(p => p.BankCode)
                .IsRequired();

            builder.Property(p => p.CardNumber)
                .IsRequired();

            builder.HasOne(p => p.MerchantInfo)
                    .WithMany(w => w.BankCards)
                    .HasForeignKey(h => h.MerchantId);

        }
    }
}
