using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Services;
using HYPJ.Web.Core.WebApi;
using HypjCms.Web.Base;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HypjCms.Web.Controllers.Sys
{
    public class SysRoleController : BaseController
    {
        private readonly PassportService passportService;

        public SysRoleController(PassportService passportService)
        {
            this.passportService = passportService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var roles = await passportService.GetAllRoles();
            return View(roles);
        }

        [HttpGet]
        public IActionResult Add()
        {
            //var moduels= passportService.GetModuleByUser(CurrUser.Id).GetAwaiter().GetResult();

            var menus = passportService.GetMenusByAccountId(CurrUser.Id).GetAwaiter().GetResult();
            return View(menus);
        }

        //[HttpPost]
        //public async Task<ApiResult> Add(AddRoleInput input)
        //{
        //    throw new System.Exception();
        //}
    }
}
