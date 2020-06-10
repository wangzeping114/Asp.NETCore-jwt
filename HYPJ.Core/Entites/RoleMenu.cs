using HYPJ.Core.Enums;
using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    public class RoleMenu:Entity<int>
    {
        /// <summary>
        /// 权限
        /// </summary>
        public Permission Permission { get; set; }

        /// <summary>
        /// 菜单
        /// </summary>
        public int MenuId { get; set; }

        /// <summary>
        /// 菜单列表
        /// </summary>
        public virtual Menu Menu { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        ///角色 
        /// </summary>
        public virtual Role Role { get; set; }
    }
}
