using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Models;

namespace Olympics_Larsen.Controllers
{
    public class FavoritesController : Controller
    {
        private CountryContext context;
        public FavoritesController(CountryContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            var session = new OlympicsSession(HttpContext.Session);
            var model = new CountriesViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
                ActiveLocation = session.GetActiveLocation(),
                Countries = session.GetMyCountries()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(Country country)
        {
            country = context.Countries
                .Include(c => c.Game)
                .Include(c => c.Sport)
                .Include(c => c.Location)
                .Where(c => c.CountryID == country.CountryID)
                .FirstOrDefault() ?? new Country();

            var session = new OlympicsSession(HttpContext.Session);
            var cookies = new OlympicsCookies(Response.Cookies);

            var countries = session.GetMyCountries();
            countries.Add(country);
            session.SetMyCountries(countries);
            cookies.SetMyCountryIDs(countries);

            TempData["message"] = $"{country.CountryName} added to your favorites";
            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveSport = session.GetActiveSport(),
                    ActiveLocation = session.GetActiveLocation()
                });
        }
        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicsSession(HttpContext.Session);
            var cookies = new OlympicsCookies(Response.Cookies);

            session.RemoveMyCountries();
            cookies.RemoveMyCountryIDs();

            TempData["message"] = "Favorite Countries cleared";
            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveSport = session.GetActiveSport(),
                    ActiveLocation = session.GetActiveLocation()
                });
        }


            
    }
}

