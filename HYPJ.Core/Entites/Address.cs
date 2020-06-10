using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 地址
    /// </summary>
    public class Address : Entity<int>
    {
        /// <summary>
        /// 国家
        /// </summary>
        /// <value>The country.</value>
        public string Country { get; set; } = "中国";

        /// <summary>
        /// 国家代码
        /// </summary>
        /// <value>The country code.</value>
        public string CountryCode { get; set; } = "86";

        /// <summary>
        /// 省份
        /// </summary>
        /// <value>The province.</value>
        public string Province { get; set; }

        /// <summary>
        /// 省份编号
        /// </summary>
        /// <value>The province code.</value>
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        /// <value>The city code.</value>
        public string CityCode { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 地区编号
        /// </summary>
        /// <value>The district code.</value>
        public string DistrictCode { get; set; }


        /// <summary>
        /// 地址详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 客户地址
        /// </summary>
        public virtual CustomerAddress CustomerAddress { get; set; }

        /// <summary>
        /// 商户地址
        /// </summary>
        public virtual StoreAddress StoreAddress { get; set; }

        /// <summary>
        /// 订单地址
        /// </summary>
        public virtual OrderAddress OrderAddress { get; set; }
    }
}
