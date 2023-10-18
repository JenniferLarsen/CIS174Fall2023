using Olympics_Larsen.Models;

namespace Olympics_Larsen.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private CountryContext context;
        public CountryRepository(CountryContext cntx)
        {
            context = cntx;
        }
        public List<Country> GetAllCountries()
        {
            return context.Countries.ToList();
        }
        public List<Sport> GetAllSports()
        {
            return context.Sports.ToList();
        }

        public List<Game> GetAllGames()
        {
            return context.Games.ToList();
        }

        public List<Location> GetAllLocations()
        {
            return context.Locations.ToList();
        }

        public void DeleteCountry(Country country)
        {
            context.Countries.Remove(country);
            context.SaveChanges();
        }


        public void InsertCountry(Country country)
        {
            context.Countries.Add(country);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateCountry(Country country)
        {
            context.Countries.Update(country);
        }
    }
}
