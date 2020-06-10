using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 广告位
    /// </summary>
    public class Advert : Entity<int>
    {

        public Advert()
        {
            MaxNumber = 4;
            FailureAt = DateTime.Now;
        }
        /// <summary>
        /// 广告图片路径
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Image Alt 标签
        /// </summary>
        public string Alt { get; set; }

        /// <summary>
        /// 最大显示数量
        /// </summary>
        public int MaxNumber { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        public DateTime FailureAt { get; set; }

        public bool IsShow { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual ICollection<AdvertCommodity> AdvertCommodities { get; set; }


    }
}
