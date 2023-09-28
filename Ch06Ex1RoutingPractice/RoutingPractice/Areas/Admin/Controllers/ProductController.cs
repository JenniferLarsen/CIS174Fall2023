using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Content("Admin Product");
        }
    }
}
