using AuthenticationTry1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationTry1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
                _userManager = userManager;
                _signInManager = signInManager;
        }
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser {Email=registerViewModel.Email,UserName=registerViewModel.UserName};
               var registered= await _userManager.CreateAsync(user,registerViewModel.Password);
                if(registered.Succeeded)
                {
                   await _signInManager.SignInAsync(user, isPersistent: false);
                }
            }
            return View();
        }
    }
}
