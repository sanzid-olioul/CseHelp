using Microsoft.AspNetCore.Mvc;

namespace CSEhelp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
