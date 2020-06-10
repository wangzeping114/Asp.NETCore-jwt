using Microsoft.AspNetCore.Mvc;
namespace HYPJ.MVC.Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
     }
}
