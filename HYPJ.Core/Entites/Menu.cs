using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    public class Menu : Entity<int>
    {
        public Menu()
        {
            Children = new HashSet<Menu>();
            RoleMenus = new HashSet<RoleMenu>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 链接动作
        /// </summary>
        public string ActionSref { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Menu Parent { get; set; }

        /// <summary>
        /// path路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 子类
        /// </summary>
        public virtual ICollection<Menu> Children { get; set; }

        /// <summary>
        /// 菜单列表
        /// </summary>
        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
