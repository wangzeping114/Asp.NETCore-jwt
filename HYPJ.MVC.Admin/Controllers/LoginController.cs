using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Services;
using HYPJ.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HYPJ.MVC.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly PassportService _passPortService;
        public LoginController(PassportService passPortService)
        {
            _passPortService = passPortService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSiginInput model)
        {
            if (ModelState.IsValid)
            {
                var user = await _passPortService.SiginAsync(model);
                HttpContext.Session.SetString("CurrentUserId", user.Id.ToString());
                //HttpContext.Session.Set("CurrentUser", ByteConvertHelper.ObjectToBytes(user));
                return RedirectToAction("Index", "Home");
            }
            foreach (var item in ModelState.Values)
            {
                if (item.Errors.Count > 0)
                {
                    ViewBag.ErrorInfo = item.Errors[0].ErrorMessage;
                    break;
                }
            }
            return View(model);
        }
    }
}