using HYPJ.Core.Enums;
using HYPJ.Core.SeedWorks;
using System;

namespace HYPJ.Core.Entites
{
    public class WxCustomer : Entity<long>
    {
        public WxCustomer()
        {
            CreateTime = DateTime.Now;
        }
        /// <summary>
        /// 微信OpenId
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avtar { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public GenderType GenderType { get; set; }

        /// <summary>
        ///创建日期
        /// </summary>
        public DateTime CreateTime { get; set; }


        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
