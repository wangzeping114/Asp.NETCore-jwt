using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 银行卡号
    /// </summary>
    public class BankCard : Entity<long>
    {
        /// <summary>
        /// 开户行
        /// </summary>
        public string OpeningBank { get; set; }

        /// <summary>
        /// 开户行编号
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// 商户
        /// </summary>
        public int MerchantId { get; set; }

        /// <summary>
        /// 商户
        /// </summary>
        public virtual MerchantInfo MerchantInfo { get; set; }

    }
}
