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
            /**************using ViewModel****************************/

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
    }
}