using Microsoft.AspNetCore.Mvc;

namespace HYPJ.MVC.Test.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}