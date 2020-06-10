using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 商品详情标签
    /// </summary>
    public class CdyDThelabel : Entity<int>
    {
        /// <summary>
        /// 随时随买、特殊产品不可退、有条件退、需提前预定、商家窗口兑票
        /// </summary>
        public string TheLabel { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public virtual ICollection<CdyDThelabelCommodityDetail> CdyDThelabelCommodityDetails { get; set; }
    }
}
