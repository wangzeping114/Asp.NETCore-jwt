using HYPJ.Applicatoin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HYPJ.MVC.Admin.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly PassportService _passportService;

        public NavigationViewComponent(PassportService passportService)
        {
            _passportService = passportService;
        }

        public IViewComponentResult Invoke()
        {
            var userId = HttpContext.Session.GetString("CurrentUserId");
            //var menus = _passportService.GetModuleByUser(int.Parse(userId)).GetAwaiter().GetResult();
            return View(menus);
        }
    }
}
