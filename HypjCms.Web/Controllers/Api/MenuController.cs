using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Resources;
using HYPJ.Applicatoin.Services;
using HYPJ.Web.Core.WebApi;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HypjCms.Web.Controllers.Api
{
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private readonly PassportService passportService;

        public MenuController(PassportService passportService)
        {
            this.passportService = passportService;
        }
        [HttpPost]
        public async Task<ApiResult> post([FromBody] MenuInput input)
        {
            await passportService.AddMenuAysnc(input);
            return ApiResult.Success;
        }

        [HttpGet]
        public async Task<ApiResult<List<MenuResource>>> get()
        {
            var menus = await passportService.GetMenus();
            return new ApiResult<List<MenuResource>>(menus);
        }
    }
}
