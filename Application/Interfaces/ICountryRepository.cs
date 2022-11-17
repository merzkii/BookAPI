using BookAPI.Application.DTO;
using BookAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Application.Interfaces
{
    public interface ICountryRepository
    {
        Task<int> CreateCountry(CountryDTO countryDTO);
        Task<ICollection<Country>> GetCountries();
        Task<Country>GetCountry(int id);
        Task<int>UpdateCountry(UpdateCountryDTO updatecountryDTO);
    }
}
