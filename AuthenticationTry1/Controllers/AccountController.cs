using Microsoft.AspNetCore.Mvc;

namespace AuthenticationTry1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }
    }
}
