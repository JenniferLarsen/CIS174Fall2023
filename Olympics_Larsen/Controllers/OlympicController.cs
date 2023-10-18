using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Olympics_Larsen.Models;
using Olympics_Larsen.Controllers;
using System.Diagnostics;
using Microsoft.IdentityModel.Tokens;

namespace Olympics_Larsen.Controllers
{
    public class OlympicController : Controller
    {
        private CountryContext context;

        public OlympicController(CountryContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public ViewResult Index(CountriesViewModel model)
        {
            ViewBag.Message = TempData["message"];
            IQueryable<Country> query = context.Countries.OrderBy(c => c.CountryName);
            if (model.ActiveGame != "all")
                query = query.Where(
                    c => c.Game.GameID.ToLower() == model.ActiveGame.ToLower());


            if (model.ActiveLocation != "all")
                query = query.Where(
                    c => c.Location.LocationID.ToLower() == model.ActiveLocation.ToLower());

            if (model.ActiveSport != "all")
                query = query.Where(
                    c => c.Sport.SportID.ToLower() == model.ActiveSport.ToLower());

            model.Countries = query.ToList();
            return View(model);
        }



        public RedirectToActionResult Index() => RedirectToAction("List", "Country");

        [HttpPost]
        public RedirectToActionResult Add(Country country)
        {
            TempData["message"] = $"(country.Name) added to your favorites";
            return RedirectToAction("Index", "Home");
        }
    }
}
    
