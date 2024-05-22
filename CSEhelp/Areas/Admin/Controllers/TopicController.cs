using Microsoft.AspNetCore.Mvc;

namespace CSEhelp.Areas.Admin.Controllers
{
    public class TopicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
