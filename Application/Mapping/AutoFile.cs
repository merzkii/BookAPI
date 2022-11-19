using AutoMapper;
using BookAPI.Application.DTO;
using BookAPI.Application.DTO.Create;
using BookAPI.Application.DTO.Update;
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
            CreateMap<Country,UpdateCountryDTO>().ReverseMap();
            CreateMap<Author,UpdateAuthorsDTO>().ReverseMap();
            CreateMap<Author2Books, UpdateAuthor2BooksDTO>().ReverseMap();
            CreateMap<Book,UpdateBooksDTO>().ReverseMap();

        }

    }
}