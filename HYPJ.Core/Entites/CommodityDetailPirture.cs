using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    public class CommodityDetailPirture : Entity<int>
    {
        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// 商品详情ID
        /// </summary>
        public int CommodityDetailId { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public virtual CommodityDetail CommodityDetail { get; set; }
    }
}
