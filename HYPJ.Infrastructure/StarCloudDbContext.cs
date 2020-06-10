using HYPJ.Core.SeedWorks;
using HYPJ.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Threading.Tasks;

namespace HYPJ.Infrastructure
{
    public class StarCloudDbContext : DbContext, IUnitOfWork
    {
        public StarCloudDbContext(DbContextOptions<StarCloudDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //忽略EF警告
            optionsBuilder.ConfigureWarnings(warnings =>
            {
                warnings.Ignore(CoreEventId.IncludeIgnoredWarning);
                warnings.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning);
                warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning);
            });
            //启用延迟加载
            optionsBuilder.UseLazyLoadingProxies();
        }

        /// <summary>
        /// 使用Fluent API来覆盖从代码到数据库的默认映射
        /// example look this.<see cref="https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx"/> 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("LYPJ");
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new AdvertConfiguration());
            modelBuilder.ApplyConfiguration(new BankCardConfiguration());
            modelBuilder.ApplyConfiguration(new BillsFlowConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CdyDThelabelConfiguration());
            modelBuilder.ApplyConfiguration(new CdySalesPlanConfiguration());
            modelBuilder.ApplyConfiguration(new CdyThelabelConfiguration());
            modelBuilder.ApplyConfiguration(new CdySmallestUnitConfiguration());
            modelBuilder.ApplyConfiguration(new CommodityConfiguration());
            modelBuilder.ApplyConfiguration(new CommodityDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CommodityDetailPirtureConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerAddressConfiguration());
            modelBuilder.ApplyConfiguration(new MerchantInfoConfiguration());
            modelBuilder.ApplyConfiguration(new OrderAddressConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentRecordConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new SetMealConfiguration());
            modelBuilder.ApplyConfiguration(new SetMealStockConfiguration());
            modelBuilder.ApplyConfiguration(new StockConfiguration());
            modelBuilder.ApplyConfiguration(new StoreAddressConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new WxCustomerConfiguration());
            modelBuilder.ApplyConfiguration(new AdvertCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new CdyThelabelCommoditiesConfiguration());
            modelBuilder.ApplyConfiguration(new CdySmallestUnitCommoditiesConfiguration());
            modelBuilder.ApplyConfiguration(new CdyDThelabelCommodityDetailConfiguration());
            modelBuilder.ApplyConfiguration(new StoreCommoditiesConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new RoleMenuConfiguration());
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
