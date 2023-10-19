using System.Text.Json;

namespace Olympics_Larsen.Models
{
    public class OlympicsSession
    {
        private const string CountriesKey = "mycountries";
        private const string CountKey = "countrycount";
        private const string GameKey = "game";
        private const string LocationKey = "location";
        private const string SportKey = "sport";

        private ISession session { get; set; }
        public OlympicsSession(ISession session) => this.session = session;

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() => session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey);

        public void SetActiveGame(string activeGame) => session.SetString(GameKey, activeGame);
        public string GetActiveGame() => session.GetString(GameKey) ?? string.Empty;

        public void SetActiveLocation(string activeLocation) => session.SetString(LocationKey, activeLocation);
        public string GetActiveLocation() => session.GetString(LocationKey) ?? string.Empty;

        public void SetActiveSport(string activeSport) => session.SetString(SportKey, activeSport);
        public string GetActiveSport() => session.GetString(SportKey) ?? string.Empty;

        public void RemoveMyCountries()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}
