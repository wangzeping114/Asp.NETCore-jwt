using System.ComponentModel;

namespace HYPJ.Core.Enums
{
    /// <summary>
    /// 性别
    /// </summary>
    [Description("性别")]
    public enum GenderType
    {
        /// <summary>
        /// 未指定
        /// </summary>
        [Description("未指定")]
        Unknown = 0,

        /// <summary>
        /// 男性
        /// </summary>
        [Description("男性")]
        Male,

        /// <summary>
        /// 女性
        /// </summary>
        [Description("女性")]
        Female
    }
}
