using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Models;
using System.Diagnostics;

namespace Olympics_Larsen.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;
        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(CountriesViewModel model)
        {
            var session = new OlympicsSession(HttpContext.Session);
            session.SetActiveGame(model.ActiveGame);
            session.SetActiveSport(model.ActiveSport);
            session.SetActiveLocation(model.ActiveLocation);

            int? count = session.GetMyCountryCount();
            if (!count.HasValue)
            {
                var cookies = new OlympicsCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountriesIDs();

                if (ids.Length > 0)
                {
                    var mycountries = context.Countries
                        .Include(c => c.Game)
                        .Include(c => c.Sport)
                        .Include(c => c.Location)
                        .Where(c => ids.Contains(c.CountryID))
                        .ToList();
                    session.SetMyCountries(mycountries);
                }
            }

            model.Games = context.Games.ToList();
            model.Sports = context.Sports.ToList();
            model.Locations = context.Locations.ToList();

            IQueryable<Country> query = context.Countries.Include(l => l.Location).Include(s => s.Sport).Include(g => g.Game).OrderBy(c => c.Game);
            if (model.ActiveGame != "all")
                query = query.Where(c => c.Game.GameID.ToLower() == model.ActiveGame.ToLower());
            if (model.ActiveSport != "all")
                query = query.Where(c => c.Sport.SportID.ToLower() == model.ActiveSport.ToLower());
            if (model.ActiveLocation != "all")
                query = query.Where(l => l.Location.LocationID.ToLower() == model.ActiveLocation.ToLower());
            model.Countries = query.ToList();
            return View(model);
        }

        public ViewResult Details(string id)
        {
            var session = new OlympicsSession(HttpContext.Session);
            var model = new CountriesViewModel
            {
                Country = context.Countries
                    .Include(g => g.Game)
                    .Include(s => s.Sport)
                    .Include(l => l.Location)
                    .FirstOrDefault(c => c.CountryID == id) ?? new Country(),
                ActiveGame = session.GetActiveGame(),
                ActiveLocation = session.GetActiveLocation(),
                ActiveSport = session.GetActiveSport()
            };
            return View(model);
            
        }
    }
}