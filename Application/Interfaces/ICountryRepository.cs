using BookAPI.Application.DTO;
using BookAPI.Application.DTO.Update;
using BookAPI.Domain;

namespace BookAPI.Application.Interfaces
{
    public interface ICountryRepository
    {
        Task<int> CreateCountry(CountryDTO countryDTO);
        Task<ICollection<Country>> GetCountries();
        Task<Country>GetCountry(int id);
        Task<int>UpdateCountry(UpdateCountryDTO updatecountryDTO);
        Task<Country> DeleteCountry(int id);
    }
}
