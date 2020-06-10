using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    public class Role : Entity<int>
    {
        public Role()
        {
            RoleMenus = new HashSet<RoleMenu>();
        }
        /// <summary>
        /// 角色名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// 是否是超级管理员
        /// </summary>
        public bool IsSuperAdmin { get; set; } = false;

        /// <summary>
        /// 账号列表
        /// </summary>
        public virtual ICollection<Account> AccountModels { get; set; }

        /// <summary>
        /// 菜单列表
        /// </summary>
        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
