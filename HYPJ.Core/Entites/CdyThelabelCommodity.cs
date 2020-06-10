using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    public class CdyThelabelCommodity : Entity<int>
    {


        public int CdyThelabelId { get; set; }
        public virtual CdyThelabel CdyThelabel { get; set; }

        public int CommdityId { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}
