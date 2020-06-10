using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    public class AdvertCommodity : Entity<int>
    {


        public int CommodityId { get; set; }

        public virtual Commodity Commodity { get; set; }

        public int AdvertId { get; set; }

        public virtual Advert Advert { get; set; }

    }
}
