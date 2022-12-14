using BookAPI.Application.DTO.Create;
using BookAPI.Application.DTO.Update;
using BookAPI.Domain;

namespace BookAPI.Application.Interfaces
{
    public interface IAuthor2BooksRepository
    {
        Task<int> CreateAuthor2Books(Author2BooksDTO author2BooksDTO);
        Task<ICollection<Author2Books>> GetAuthor2Books();
        Task<Author2Books>GetAuthor2Book(int id);
        Task<int>UpdateAuthor2Books(UpdateAuthor2BooksDTO updateAuthor2BooksDTO);
        Task<Author2Books>DeleteAuthor2Books(int id);
    }
}
