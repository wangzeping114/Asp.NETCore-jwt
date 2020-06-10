using HYPJ.Core.Paging.Attributes;
using System;

namespace HYPJ.Applicatoin.Resources
{
    /// <summary>
    /// 操作管理员
    /// </summary>
    public class SysOperatorResource
    {
        [PropertyMapping]
        public int Id { get; set; }

        [PropertyMapping]
        public string UserName { get; set; }

        [PropertyMapping]
        public string FullName { get; set; }

        [PropertyMapping]
        public string Phone { get; set; }

        [PropertyMapping]
        public int RoleId { get; set; }

        [PropertyMapping]
        public string RoleName { get; set; }

        /// <summary>
        ///生日
        /// </summary>
        [PropertyMapping]
        public DateTime BirthOn { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [PropertyMapping]
        public string Remark { get; set; }

        /// <summary>
        /// 账号是否停用
        /// </summary>
        [PropertyMapping]
        public bool IsDisplay { get; set; }

        /// <summary>
        /// 账号创建时间
        /// </summary>
        [PropertyMapping]
        public DateTime CreateAt { get; set; }


    }
}
