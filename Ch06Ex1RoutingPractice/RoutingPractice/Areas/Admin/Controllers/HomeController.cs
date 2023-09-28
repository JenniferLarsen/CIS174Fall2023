using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Admin Home");
        }
    }
}
