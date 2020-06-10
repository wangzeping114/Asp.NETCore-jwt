using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    public class CdyDThelabelCommodityDetail : Entity<int>
    {

        public int CdyDThelabelId { get; set; }
        public virtual CdyDThelabel CdyDThelabel { get; set; }

        public int CommodityDetailId { get; set; }
        public virtual CommodityDetail CommodityDetail { get; set; }
    }
}
