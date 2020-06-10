using HYPJ.Core.Paging.Attributes;

namespace HYPJ.Applicatoin.Resources
{
    public class RoleResource
    {
        /// <summary>
        /// ID
        /// </summary>
        [PropertyMapping]
        public int Id { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [PropertyMapping]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [PropertyMapping]
        public string Description { get; set; }
        /// <summary>
        /// 是否是超级管理员
        /// </summary>
        [PropertyMapping]
        public bool IsSuperAdmin { get; set; }
    }
}
