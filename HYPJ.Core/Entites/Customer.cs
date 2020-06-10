using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer : Entity<int>
    {
        public Customer()
        {
            CreateOn = DateTime.Now;
            LastOn = DateTime.Now;
        }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 密码加盐
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastOn { get; set; }

        /// <summary>
        /// 微信客户
        /// </summary>
        public virtual WxCustomer WxCustomer { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }

        /// <summary>
        /// 默认下单地址ID
        /// </summary>
        public long? DefaultBillingAddressId { get; set; }

        /// <summary>
        /// 默认下单地址
        /// </summary>
        public virtual CustomerAddress DefaultBillingAddress { get; set; }

        /// <summary>
        /// 客户地址集合
        /// </summary>
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
    }
}
