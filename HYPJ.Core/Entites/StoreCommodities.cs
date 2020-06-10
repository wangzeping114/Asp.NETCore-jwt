using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    public class StoreCommodities : Entity<int>
    {

        public int StoreId { get; set; }
        public virtual Store Store { get; set; }

        public int CommodityId { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}
