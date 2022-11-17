using AutoMapper;
using BookAPI.Application.DTO;
using BookAPI.Application.Interfaces;
using BookAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Persistance.Repositories
{
    public class CountryRepository:ICountryRepository
    {
        private readonly DataContext Context;
        private readonly IMapper Mapper;
        public CountryRepository(DataContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public async Task<int>CreateCountry(CountryDTO countryDTO)
        {
            var country=Mapper.Map<Country>(countryDTO);
            Context.Countries.Add(country);
            await Context.SaveChangesAsync();
            return country.Id;
        }
        public async Task<ICollection<Country>> GetCountries()
        {
            var countries=Context.Countries.OrderBy(x=>x.Id).ToListAsync();
            return await countries;
        }
        public async Task<Country>GetCountry(int id)
        {
            var country=await Context.Countries.SingleOrDefaultAsync(x=>x.Id==id);
            if (country == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            return country;


        }
        public async Task<int>UpdateCountry(UpdateCountryDTO updateCountryDTO)
        {
            var basecountry=await GetCountry(updateCountryDTO.Id);
            if (basecountry == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            var country=Mapper.Map<Country>(updateCountryDTO);
            Context.Entry(basecountry).CurrentValues.SetValues(country);
            await Context.SaveChangesAsync();
            return country.Id;

        }
        public async Task<Country>DeleteCountry(int id)
        {
            var country=await GetCountry(id);
            Context.Remove(country);
            await Context.SaveChangesAsync();
            return country;
        }
    }
}
