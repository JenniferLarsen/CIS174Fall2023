using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Controllers;

namespace Olympics_Larsen.Models
{
    public class CountriesViewModel
    {
        public string ActiveGame { get; set; } = "all";
        public string ActiveSport { get; set; } = "all";
        public string ActiveLocation { get; set; } = "all";
        public string ActiveCountry { get; set; } = "all";
        public Country Country { get; set; } = new Country();

        public List<Country> Countries { get; set; } = new List<Country>();
        public List<Game> Games { get; set; } = new List<Game>();
        public List<Location> Locations { get; set; } = new List<Location>();
        public List<Sport> Sports { get; set; } = new List<Sport>();
        public string CheckActiveGame(string c) => c.ToLower() == ActiveGame.ToLower() ? "active" : "";
        public string CheckActiveLocation(string c) => c.ToLower() == ActiveLocation.ToLower() ? "active" : "";
        public string CheckActiveSport(string c) => c.ToLower() == ActiveSport.ToLower() ? "active" : "";
    }
}
