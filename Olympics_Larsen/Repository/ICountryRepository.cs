using Olympics_Larsen.Models;

namespace Olympics_Larsen.Repository
{
   
    public interface ICountryRepository
    {
        List<Game> GetAllGames();
        List<Sport> GetAllSports();

        void Save();
        void InsertCountry(Country country);
        void DeleteCountry(Country country);
        void UpdateCountry(Country country);
    }
}
