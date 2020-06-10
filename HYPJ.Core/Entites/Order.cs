using HYPJ.Core.Enums;
using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order : Entity<long>
    {
        public Order()
        {
            CreatedOn = DateTime.Now;
            LatestUpdatedOn = DateTime.Now;
            OrderStatus = OrderStatus.新订单;
        }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderSerialNumber { get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        public DateTime LatestUpdatedOn { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// (小计/共计)
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// 订单总额
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// 订单数量
        /// </summary>
        public int OrderCount { get; set; }

        /// <summary>
        /// 商品标题或名称
        /// </summary>
        public string TitileOrName { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public string CommoditySerialNumber { get; set; }


        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderStatus OrderStatus { get; set; }


        /// <summary>
        /// 客户ID
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        public virtual Customer Customer { get; set; }

        public virtual OrderAddress OrderAddress { get; set; }

        public virtual ICollection<PaymentRecord> PaymentRecords { get; set; }
    }
}
