using System.ComponentModel;

namespace HYPJ.Core.Enums
{
    [Description("权限枚举")]
    public enum Permission
    {
        /// <summary>
        /// 无, 仅用于校验是否登录
        /// </summary>
        [Description("无, 仅用于校验是否登录")]
        None = 0x000,
        /// <summary>
        /// 查询
        /// </summary>
        [Description("查询")]
        Query = 0x001,

        /// <summary>
        /// 添加
        /// </summary>
        [Description("添加")]
        Add = 0x002,

        /// <summary>
        /// 修改
        /// </summary>
        [Description("修改")]
        Update = 0x004,

        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete = 0x008,

        /// <summary>
        /// 管理
        /// </summary>
        [Description("管理")]
        Manage = 0x0010
    }
}
