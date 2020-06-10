using HYPJ.Core.SeedWorks;
using System;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 商品销售计划
    /// </summary>
    public class CdySalesPlan : Entity<int>
    {
        /// <summary>
        /// 计划金额
        /// </summary>
        public decimal PlanPrice { get; set; }

        /// <summary>
        /// 计划时间
        /// </summary>
        public DateTime PlanTime { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 商品
        /// </summary>
        public virtual Commodity Commodity { get; set; }

    }
}
