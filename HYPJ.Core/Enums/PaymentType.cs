using System.ComponentModel;

namespace HYPJ.Core.Enums
{
    [Description("支付类型")]
    public enum PaymentType
    {

        /// <summary>
        /// 男性
        /// </summary>
        [Description("微信支付")]
        WeChat,

        /// <summary>
        /// 女性
        /// </summary>
        [Description("支付宝支付")]
        AliPay

    }
}
