using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Resources;
using HYPJ.Applicatoin.Services;
using HYPJ.Utilities.Helper;
using HYPJ.Web.Core.Configs;
using HYPJ.Web.Core.WebApi;
using HypjCms.Web.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HypjCms.Web.Controllers
{
    public class AdminController : BaseController
    {
        private readonly SiteConfig siteConfig;
        private readonly PassportService passportService;

        public AdminController(IOptions<SiteConfig> siteConfig, PassportService passportService)
        {
            this.siteConfig = siteConfig.Value;
            this.passportService = passportService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            TempData["userInfo"] = CurrUser;
            var menus = passportService.GetMenusByAccountId(CurrUser.Id).GetAwaiter().GetResult();
            return View(menus);
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Title"] = siteConfig.Title;
            ViewData["Keywords"] = siteConfig.Keywords;
            ViewData["Description"] = siteConfig.Description;
            return View();
        }

        [HttpPost]
        public async Task<ApiResult> Login(UserSiginInput input)
        {
            if (string.IsNullOrWhiteSpace(input.VerifyCode) || !input.VerifyCode.Equals(CurrentVerifyCode,System.StringComparison.InvariantCultureIgnoreCase))
            {
                return ApiResult.GetRequestError("无效的验证码");
            }
            var user = await passportService.SiginAsync(input);
            WebHelper.WriteSession(SessionUser, user);
            return ApiResult.Success;
        }


        private static string CurrentVerifyCode
        {
            get
            {
                var verifyCode = WebHelper.GetCookie("VerifyCode");
                return DESEncryptHelper.DecryptDES(verifyCode);
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            WebHelper.RemoveSession(SessionUser);
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public IActionResult WelCome()
        {
            return View();
        }
    }
}