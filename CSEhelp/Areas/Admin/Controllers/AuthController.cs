using CSEhelp.Interfaces;
using CSEhelp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSEhelp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var response = await _authRepository.LoginUser(loginViewModel);
            if(response.success)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
