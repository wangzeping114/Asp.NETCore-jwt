using HYPJ.Core.Enums;
using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 账单流
    /// </summary>
    public class BillsFlow : Entity<int>
    {
        /// <summary>
        /// 支付ID
        /// </summary>
        public long PaymentRecordId { get; set; }

        /// <summary>
        /// 支付记录
        /// </summary>
        public virtual PaymentRecord PaymentRecord { get; set; }


        /// <summary>
        /// 下拨状态
        /// </summary>
        public BillsStatus BillsStatus { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 账号Id
        /// </summary>
        public int? AccountId { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public virtual Account Account { get; set; }

    }
}
