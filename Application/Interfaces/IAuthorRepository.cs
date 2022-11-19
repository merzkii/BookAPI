using BookAPI.Application.DTO.Create;
using BookAPI.Application.DTO.Update;
using BookAPI.Domain;

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
