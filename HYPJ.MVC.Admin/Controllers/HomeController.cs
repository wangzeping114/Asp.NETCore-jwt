using Microsoft.AspNetCore.Mvc;

namespace HYPJ.MVC.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
