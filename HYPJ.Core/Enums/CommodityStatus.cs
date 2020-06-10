using System.ComponentModel;

namespace HYPJ.Core.Enums
{
    /// <summary>
    /// 商品状态
    /// </summary>
    public enum CommodityStatus
    {
        [Description("下架")]
        下架 = 0,

        [Description("上架")]
        上架 = 1
    }
}
