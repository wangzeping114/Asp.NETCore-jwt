using System;
using System.ComponentModel.DataAnnotations;

namespace HYPJ.Applicatoin.Dots
{
    public class EditUserInput
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 账号
        /// </summary>
        public  string UserName { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        [Required(ErrorMessage = ("全名不能为空"))]
        public string FullName { get; set; }
        
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthOn { get; set; }

        /// <summary>
        /// 是否停用
        /// </summary>
        public bool IsDisplay { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [Required(ErrorMessage = ("手机号码不能为空"))]
        public string Phone { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Required(ErrorMessage = ("请输入绑定的角色ID"))]
        public int RoleId { get; set; }
    }
}
