using Microsoft.AspNetCore.Mvc;

namespace CSEhelp.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
