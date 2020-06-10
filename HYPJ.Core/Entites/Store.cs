using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 店、景点、特产
    /// </summary>
    public class Store : Entity<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        public DateTime BusinessTime { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 法人代表
        /// </summary>
        public string LegalPerson { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// 地址ID
        /// </summary>
        public int StoreAddressId { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public virtual StoreAddress StoreAddress { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public int MerchantId { get; set; }

        /// <summary>
        /// 商户
        /// </summary>
        public virtual MerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual ICollection<StoreCommodities> StoreCommodities { get; set; }

    }
}
