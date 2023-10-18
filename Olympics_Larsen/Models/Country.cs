using Microsoft.EntityFrameworkCore;
using Olympics_Larsen.Controllers;
using Olympics_Larsen.Models;

namespace Olympics_Larsen.Models
{
    public class Country
    {
        public string CountryID { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
        public Location Location {  get; set; } = null!;
        public Game Game {  get; set; } = null!;
        public Sport Sport { get; set; } = null!;
        public string FlagImage {  get; set; } = string.Empty;
        public string GameID { get; internal set; } = null!;
        public string SportID { get; internal set; } = null!;
        public string LocationID { get; internal set; } = null!;
    }
}
