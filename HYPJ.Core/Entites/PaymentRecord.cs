using HYPJ.Core.Enums;
using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 付款记录
    /// </summary>
    public class PaymentRecord : Entity<long>
    {

        /// <summary>
        /// 流水号
        /// </summary>
        public string PaymentSerialNumber { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        public PaymentType PaymentType { get; set; }


        /// <summary>
        /// 订单编号
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        public virtual Order Order { get; set; }


        public virtual BillsFlow BillsFlow { get; set; }
    }
}
