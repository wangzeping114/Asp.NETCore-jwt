using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class MerchantInfoConfiguration : IEntityTypeConfiguration<MerchantInfo>
    {
        public void Configure(EntityTypeBuilder<MerchantInfo> builder)
        {
            builder.Property(p => p.MerchatId)
                    .IsRequired();

            builder.Property(p => p.Name)
                   .IsRequired();

            builder.Property(p => p.IdCard)
                   .IsRequired(false);

            builder.Property(p => p.Phone)
                    .IsRequired();

            builder.Property(p => p.BankCardId);

            builder.Ignore(c => c.DefaultBankCard);



        }
    }
}
