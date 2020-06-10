using HYPJ.Core.Enums;
using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Commodity : Entity<int>
    {
        public Commodity()
        {
            CreateTime = DateTime.Now;
        }
        /// <summary>
        /// 商品标题或名称
        /// </summary>
        public string TitileOrName { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        public CommodityStatus CommodityStatus { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 门市价
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// 下架时间
        /// </summary>
        public DateTime? ShelfTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime AsOfTime { get; set; }

        /// <summary>
        /// 栏目ID
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        ///栏目
        /// </summary>
        public virtual Category Category { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public virtual Stock Stock { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public virtual CommodityDetail CommodityDetail { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        public virtual ICollection<CdyThelabelCommodity> CdyThelabelCommodities { get; set; }

        /// <summary>
        /// 商户商店列表
        /// </summary>
        public virtual ICollection<StoreCommodities> StoreCommodities { get; set; }

        /// <summary>
        /// 商品销售计划
        /// </summary>
        public virtual ICollection<CdySalesPlan> CdySalesPlans { get; set; }

        /// <summary>
        /// 最小单元
        /// </summary>
        public virtual ICollection<CdySmallestUnitCommodities> CdySmallestUnitCommodities { get; set; }

        /// <summary>
        /// 广告位
        /// </summary>
        public virtual ICollection<AdvertCommodity> AdvertCommodities { get; set; }


    }
}
