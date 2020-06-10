using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    public class Account : Entity<int>
    {
        public Account()
        {
            CreatedOn = DateTime.Now;
            LatestUpdatedOn = DateTime.Now;
            IsDisplay = false;
        }

        /// <summary>
        /// 是否停用
        /// </summary>
        public bool IsDisplay { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 最后登陆时间
        /// </summary>  
        public DateTime LatestUpdatedOn { get; set; }
        /// <summary>
        /// 安全票据 校验密码
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// 出生年月
        /// </summary>
        public DateTime? BirthOn { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public virtual Role Role { get; set; }


        public virtual ICollection<BillsFlow> BillsFlows { get; set; }
    }
}
