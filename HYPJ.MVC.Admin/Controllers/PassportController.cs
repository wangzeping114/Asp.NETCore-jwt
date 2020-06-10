using Microsoft.AspNetCore.Mvc;

namespace HYPJ.MVC.Admin.Controllers
{
    [Route("manage")]
    public class PassportController : BaseController
    {
        [HttpGet("account")]
        public IActionResult Account()
        {
            return View();
        }
    }
}