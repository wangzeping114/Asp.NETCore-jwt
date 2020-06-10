using System.ComponentModel.DataAnnotations;

namespace HYPJ.Applicatoin.Dots
{
    /// <summary>
    /// 用户登录DTO
    /// </summary>
    public class UserSiginInput
    {
        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage = "请输入登陆账号")]
        [MinLength(4, ErrorMessage = "账号至少要4位")]
        [MaxLength(8, ErrorMessage = "账号长度为8位")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = ("请输入密码"))]
        [MinLength(4, ErrorMessage = "密码至少要4位")]
        [MaxLength(8, ErrorMessage = "密码长度不能超过8位")]
        public string PassWord { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string VerifyCode { get; set; }

        /// <summary>
        /// 记住我
        /// </summary>
        public bool RememberMe { get; set; }
    }
}
