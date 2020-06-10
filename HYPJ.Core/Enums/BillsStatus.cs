using System.ComponentModel;

namespace HYPJ.Core.Enums
{
    /// <summary>
    /// 下拨状态
    /// </summary>
    public enum BillsStatus
    {
        [Description("已下拨")]
        已下拨 = 200,

        [Description("未下拨")]
        未下拨 = 204,
    }
}
