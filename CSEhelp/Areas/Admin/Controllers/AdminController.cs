using Microsoft.AspNetCore.Mvc;

namespace CSEhelp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
