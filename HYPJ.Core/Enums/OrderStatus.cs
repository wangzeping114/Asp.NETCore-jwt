using System.ComponentModel;

namespace HYPJ.Core.Enums
{
    /// <summary>
    /// 订单状态
    /// </summary>
    [Description("订单状态")]
    public enum OrderStatus
    {

        /// <summary>
        /// 新订单
        /// </summary>
        [Description("新订单")]
        新订单 = 1,

        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        已完成 = 70,

        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        已取消 = 80,

        /// <summary>
        /// 已退还
        /// </summary>
        [Description("已退款")]
        已退款 = 90,

        /// <summary>
        /// 已关闭
        /// </summary>
        [Description("已关闭")]
        已关闭 = 100,

    }
}
