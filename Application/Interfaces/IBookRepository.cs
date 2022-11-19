using BookAPI.Application.DTO.Create;
using BookAPI.Application.DTO.Update;
using BookAPI.Domain;

namespace BookAPI.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<int> CreateBook(BookDTO bookDTO);
        Task<ICollection<Book>> GetBooks();
        Task<Book>GetBook(int id);
        Task<int>UpdateBook(UpdateBooksDTO updatebookDTO);
        Task <Book> DeleteBook(int id);
    }
}
