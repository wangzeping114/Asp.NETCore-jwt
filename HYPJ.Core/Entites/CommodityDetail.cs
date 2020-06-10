using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 商品详情
    /// </summary>
    public class CommodityDetail : Entity<int>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int CommodityId { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual Commodity Commodity { get; set; }

        /// <summary>
        /// 图片列表
        /// </summary>
        public virtual ICollection<CommodityDetailPirture> CommodityDetailPirtures { get; set; }

        /// <summary>
        /// 商品详情标签
        /// </summary>
        public virtual ICollection<CdyDThelabelCommodityDetail> CdyDThelabelCommodityDetails { get; set; }


        /// <summary>
        /// 活动地址说明
        /// </summary>

        public string ActivityAddressDescription { get; set; }

        /// <summary>
        /// 活动时间说明
        /// </summary>
        public string ActivityTimeDescription { get; set; }

        /// <summary>
        /// 需知《图片路径》
        /// </summary>
        public string NeedKnowPath { get; set; }

        /// <summary>
        /// 说明《图片路径》
        /// </summary>
        public string DetailPath { get; set; }


    }
}
