using Microsoft.AspNetCore.Mvc;
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

            IQueryable<Country> query = context.Countries.OrderBy(c => c.Game);
            if (model.ActiveGame != "all")
                query = query.Where(c => c.Game.GameID.ToLower() == model.ActiveGame.ToLower());
            if (model.ActiveSport != "all")
                query = query.Where(c => c.Sport.SportID.ToLower() == model.ActiveSport.ToLower());
            model.Countries = query.ToList();
            return View(model);
        }
    }
}