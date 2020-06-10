using HYPJ.MVC.Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HYPJ.MVC.Test.Controllers
{
    public class AdminController : Controller
    {
        private readonly SiteConfig _siteConfig;

        public AdminController(IOptions<SiteConfig> siteConfig)
        {
            _siteConfig = siteConfig.Value;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Title"] = _siteConfig.Title;
            ViewData["Keywords"] = _siteConfig.Keywords;
            ViewData["Description"] = _siteConfig.Description;
            return View();
        }

        public IActionResult WelCome()
        {
            return View();
        }
    }
}