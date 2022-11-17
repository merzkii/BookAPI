using BookAPI.Application.DTO;
using BookAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
