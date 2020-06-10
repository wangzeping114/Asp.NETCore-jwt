using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    ///商户信息
    /// </summary>
    public class MerchantInfo : Entity<int>
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public long MerchatId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public long? BankCardId { get; set; }

        /// <summary>
        /// 默认银行卡
        /// </summary>
        public virtual BankCard DefaultBankCard { get; set; }

        /// <summary>
        /// 店铺列表
        /// </summary>
        public virtual ICollection<Store> Stores { get; set; }

        /// <summary>
        /// 银行卡列表
        /// </summary>
        public virtual ICollection<BankCard> BankCards { get; set; }
    }
}
