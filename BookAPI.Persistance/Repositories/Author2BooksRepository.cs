using AutoMapper;
using BookAPI.Application.DTO.Create;
using BookAPI.Application.DTO.Update;
using BookAPI.Application.Interfaces;
using BookAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Persistance.Repositories
{
    public class Author2BooksRepository: IAuthor2BooksRepository
    {
        private readonly DataContext Context;
        private readonly IMapper Mapper;
        public Author2BooksRepository(DataContext context,IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public async Task<int>CreateAuthor2Books(Author2BooksDTO author2BooksDTO)
        {
            var author2book=Mapper.Map<Author2Books>(author2BooksDTO);
            Context.Author2Books.Add(author2book);
            await Context.SaveChangesAsync();
            return author2book.Id;
        }
        public async Task<ICollection<Author2Books>> GetAuthor2Books()
        {
            var getAuthor2books= Context.Author2Books.OrderBy(x=>x.Id).ToListAsync();
            return await getAuthor2books;
        }
        public async Task<Author2Books>GetAuthor2Book(int id)
        {
            var getauthor2books= await Context.Author2Books.SingleOrDefaultAsync(x => x.Id == id);
            if (getauthor2books == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            return getauthor2books;
        }
        public async Task<int>UpdateAuthor2Books(UpdateAuthor2BooksDTO updateAuthor2BooksDTO)
        {
            var frombase=await GetAuthor2Book(updateAuthor2BooksDTO.Id);
            if (frombase == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            var author2book = Mapper.Map<Author2Books>(updateAuthor2BooksDTO);
            Context.Entry(frombase).CurrentValues.SetValues(author2book);
            await Context.SaveChangesAsync();
            return author2book.Id;

        }
        public async Task<Author2Books>DeleteAuthor2Books(int id)
        {
            var author2books= await GetAuthor2Book(id);
            Context.Author2Books.Remove(author2books);
            await Context.SaveChangesAsync();
            return author2books;
        }
    }
}
