using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    public class CdySmallestUnitCommodities : Entity<int>
    {

        public int CdySamllestUnitId { get; set; }

        public virtual CdySmallestUnit CdySmallestUnit { get; set; }

        public int CommodityId { get; set; }

        public virtual Commodity Commodity { get; set; }
    }
}
