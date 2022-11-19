using BookAPI.Application.DTO;
using BookAPI.Application.DTO.Update;
using BookAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace BookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CountryController:ControllerBase
    {
        public ICountryRepository CountryRepository { get; set; }
        public CountryController(ICountryRepository countryRepository)
        {
            CountryRepository = countryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCountry(CountryDTO countryDTO)
        {
            var country=await CountryRepository.CreateCountry(countryDTO);
            return Ok(country);
        }
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            var countries = await CountryRepository.GetCountries();
            return Ok(countries);
        }
        [HttpGet]
        public async Task<IActionResult>GetCountry(int id)
        {
            var country= await CountryRepository.GetCountry(id);
            return Ok(country);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCountry(UpdateCountryDTO updatecountryDTO)
        {
            var updatecountry=await CountryRepository.UpdateCountry(updatecountryDTO);
            return Ok(updatecountry);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var deletecountry=await CountryRepository.DeleteCountry(id);
            return Ok("ჩანაწერი წაიშალა");
        }
    }
}
