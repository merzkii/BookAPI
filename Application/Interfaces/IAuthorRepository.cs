using BookAPI.Application.DTO;
using BookAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Application
{
    public interface IAuthorRepository
    {
        Task<int> CreateAuthor(AuthorDTO authorDTO);
        Task<ICollection<Author>> GetAuthors();
        Task<Author>GetAuthor(int id);
        Task<int>UpdateAuthors(UpdateAuthorsDTO updateauthorDTO);
        Task<Author> DeleteAuthor(int id);

    }
}
