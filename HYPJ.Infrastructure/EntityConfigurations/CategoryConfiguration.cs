using HYPJ.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HYPJ.Infrastructure.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Key)
                    .IsRequired();

            builder.Property(p => p.Name)
                .IsRequired();

            builder.Property(p => p.Icon)
                .IsRequired();


        }
    }
}
