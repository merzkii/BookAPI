using AutoMapper;
using BookAPI.Application.DTO;
using BookAPI.Domain;

namespace Application
{
    public class AutoFile:Profile
    {
        public AutoFile()
        {
            CreateMap<Author,AuthorDTO>().ReverseMap();
            CreateMap<Author2Books,Author2BooksDTO>().ReverseMap();
            CreateMap<Book,BookDTO>().ReverseMap(); 
            CreateMap<Country,CountryDTO>().ReverseMap();   
        }

    }
}