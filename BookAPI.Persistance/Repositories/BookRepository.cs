using AutoMapper;
using BookAPI.Application.DTO.Create;
using BookAPI.Application.DTO.Update;
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
    public class BookRepository:IBookRepository
    {
        private readonly DataContext Context;
        private readonly IMapper Mapper;
        public BookRepository(DataContext context,IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public async Task<int>CreateBook(BookDTO bookdto)
        {
            var book = Mapper.Map<Book>(bookdto);
            Context.Books.Add(book);
            await Context.SaveChangesAsync();
            return book.Id;

        }
        public async Task<ICollection<Book>> GetBooks()
        {
            var books = Context.Books.OrderBy(x => x.Id).ToListAsync();
            return await books;
        }
        public async Task<Book>GetBook(int id)
        {
            var book=await Context.Books.SingleOrDefaultAsync(x => x.Id == id);
            if (book == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            return  book;
        }
        public async Task<int>UpdateBook(UpdateBooksDTO updatebooksdto)
        {
            var basebook=await GetBook(updatebooksdto.Id);
            if (basebook == null)
                throw new InvalidOperationException("ჩანაწერი ვერ მოიძებნა");
            var book=Mapper.Map<Book>(updatebooksdto);
            Context.Entry(basebook).CurrentValues.SetValues(book);
            await Context.SaveChangesAsync();
            return book.Id;
        }
        public async Task<Book>DeleteBook(int id)
        {
            var book=await GetBook(id);
            Context.Remove(book);
            await Context.SaveChangesAsync();
            return book;
        }
    }
}
