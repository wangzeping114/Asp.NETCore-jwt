using System.ComponentModel.DataAnnotations;

namespace HYPJ.Applicatoin.Dots
{
    /// <summary>
    /// 添加员工Dots
    /// </summary>
    public class AddUserInput
    {
        [Required(ErrorMessage = "登陆账号不能为空")]
        [MinLength(4, ErrorMessage = "账号至少要4位")]
        [MaxLength(8, ErrorMessage = "账号长度为8位")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = ("密码不能为空"))]
        [MinLength(4, ErrorMessage = "密码至少要4位")]
        [MaxLength(8, ErrorMessage = "密码长度不能超过8位")]
        public string PassWord { get; set; }


        /// <summary>
        /// 全名
        /// </summary>
        [Required(ErrorMessage = ("全名不能为空"))]
        public string FullName { get; set; }


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
