namespace Olympics_Larsen.Models
{
    public class OlympicsCookies
    {
        private const string CountriesKey = "mycountries";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; } = null!;
        private IResponseCookies responseCookies { get; set; } = null!;

        public OlympicsCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }
        public OlympicsCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyCountryIDs(List<Country> mycountries)
        {
           List<string> ids = mycountries.Select(c => c.CountryID).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            RemoveMyCountryIDs();
            responseCookies.Append(CountriesKey, idsString, options);
        }

        public string[] GetMyCountriesIDs()
        {
            string cookie = requestCookies[CountriesKey] ?? String.Empty;
            if (string.IsNullOrEmpty(cookie))
                return Array.Empty<string>();
            else
                return cookie.Split(Delimiter);
        }

        public void RemoveMyCountryIDs()
        {
            responseCookies.Delete(CountriesKey);
        }
    }
}
