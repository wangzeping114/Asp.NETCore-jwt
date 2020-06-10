using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 商品标签
    /// </summary>
    public class CdyThelabel : Entity<int>
    {
        /// <summary>
        /// 本地/国内
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 商品标签列表
        /// </summary>
        public virtual ICollection<CdyThelabelCommodity> CdyThelabelCommodities { get; set; }
    }
}
