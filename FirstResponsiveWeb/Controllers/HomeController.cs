using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWeb.Models;

namespace FirstResponsiveWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Jennifer";
            ViewBag.BirthYear = 1981;
            ViewBag.AgeThisYear = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeThisYearModel model)
        {
            ViewBag.AgeThisYear = model.ageThisYear();
            return View(model);
        }
    }
}
