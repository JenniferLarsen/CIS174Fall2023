/*
Author: Jennifer Larsen
Date: 2023-09-27
Description: This code explores routing
*/

using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home");
        }

        [Route("About")]
        public IActionResult About()
        {
            return Content("Home controller, Index action");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null) {
                return Content("No ID supplied.");
            }
            else {
                return Content("ID: " + id);
            }
        }
    }
}