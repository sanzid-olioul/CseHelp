using CSEhelp.Entities;
using CSEhelp.Interfaces;
using CSEhelp.Models;
using Microsoft.AspNetCore.Identity;

namespace CSEhelp.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AuthRepository(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<ResponseModel> LoginUser(LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (user == null)
            {
                return new ResponseModel { message = "User not Found", statusCode = 404, success = false };
            }

            var res = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RememberMe, lockoutOnFailure: true);
            if (!res.Succeeded)
            {
                return new ResponseModel { message = "Wrong Crediantials", statusCode = 304, success = false };
            }

            return new ResponseModel { message= "Login Succeed", statusCode = 200, success = true };
        }
    }
}
