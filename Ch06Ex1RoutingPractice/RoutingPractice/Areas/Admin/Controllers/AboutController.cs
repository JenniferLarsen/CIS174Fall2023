using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("Admin About");
        }
        
    }
}
