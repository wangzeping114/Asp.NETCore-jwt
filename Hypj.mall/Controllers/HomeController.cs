using Microsoft.AspNetCore.Mvc;

namespace Hypj.Mall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
