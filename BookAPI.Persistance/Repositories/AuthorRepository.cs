using AutoMapper;
using BookAPI.Application;
using BookAPI.Application.DTO;
using BookAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Persistance.Repositories
{
    public class AuthorRepository:IAuthorRepository
    {
        private readonly DataContext Context;
        private readonly IMapper Mapper;
        public AuthorRepository(DataContext context,IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public async Task<int>CreateAuthor(AuthorDTO authorDTO)
        {
            var author=Mapper.Map<Author>(authorDTO);
            Context.Authors.Add(author);
            await Context.SaveChangesAsync();
            return author.Id;
        }
        public async Task<ICollection<Author>> GetAuthors()
        {
            var authors=Context.Authors.OrderBy(x=>x.Id).ToListAsync();
            return await authors;
        }
        public async Task<Author>GetAuthor(int id)
        {
            var author=await Context.Authors.SingleOrDefaultAsync(x=>x.Id==id);
            if (author == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            return author;
        }
        public async Task<int>UpdateAuthors(UpdateAuthorsDTO updateAuthorsDTO)
        {
            var baseauthor=await GetAuthor(updateAuthorsDTO.Id);
            if (baseauthor == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            var author=Mapper.Map<Author>(updateAuthorsDTO);
            Context.Entry(baseauthor).CurrentValues.SetValues(author);
            await Context.SaveChangesAsync();
            return author.Id;

        }
        public async Task<Author>DeleteAuthor(int id)
        {
            var author=await GetAuthor(id);
            Context.Remove(author);
            await Context.SaveChangesAsync();
            return author;
        }

    }
}
