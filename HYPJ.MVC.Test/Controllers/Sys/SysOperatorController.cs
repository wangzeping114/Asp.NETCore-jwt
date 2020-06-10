using Microsoft.AspNetCore.Mvc;

namespace HYPJ.MVC.Test.Controllers.Sys
{
    public class SysOperatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {

            return View();
        }
    }
}