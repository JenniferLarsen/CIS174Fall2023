using Microsoft.AspNetCore.Mvc;
using Olympics_Larsen.Models;
using System.Diagnostics;

namespace Olympics_Larsen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public RedirectToActionResult Index() => RedirectToAction("List");
        public RedirectToActionResult Index(string id) => RedirectToAction("Details", new Dictionary<string, string>() {{ "ID", id }});

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}