using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 最小单元
    /// </summary>
    public class CdySmallestUnit : Entity<int>
    {
        /// <summary>
        /// 单元类型,一张，一盒，一座，一箱，一份
        /// </summary>
        public string UnitType { get; set; }

        /// <summary>
        /// 商品单元
        /// </summary>
        public virtual ICollection<CdySmallestUnitCommodities> CdySmallestUnitCommodities { get; set; }

    }
}
