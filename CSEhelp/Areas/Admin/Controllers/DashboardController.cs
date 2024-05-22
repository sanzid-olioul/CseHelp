using Microsoft.AspNetCore.Mvc;

namespace CSEhelp.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
