using ReviewApp.Models;

namespace ReviewApp.Interface
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int countryId);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersByCountry(int countryId);
        bool CountryExists(int countryId);

        bool CreateCountry(Country country);

        bool updateCountry(Country country);
        bool DeleteCountry(Country country);
        bool Save();
    }
}
