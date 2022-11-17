using BookAPI.Application.DTO;
using BookAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookController:ControllerBase
    {
        public IBookRepository BookRepository { get; set; }
        public IAuthor2BooksRepository Author2BooksRepository { get; set; }
        public BookController(IBookRepository bookRepository,IAuthor2BooksRepository author2BooksRepository)
        {
            BookRepository = bookRepository;
            Author2BooksRepository = author2BooksRepository;
        }

       [HttpPost]
        public async Task<IActionResult> CreateBook(BookDTO bookDTO)
        {
            var book=await BookRepository.CreateBook(bookDTO);
            return Ok(book);
        }
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books=await BookRepository.GetBooks();
            return Ok(books);
        }
        [HttpGet]
        public async Task<IActionResult>GetBook(int id)
        {
            var book= await BookRepository.GetBook(id);
            return Ok(book);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBooksDTO updatebookDTO)
        {
            var updatebooks=await BookRepository.UpdateBook(updatebookDTO);
            return Ok(updatebooks);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var deletebook=await BookRepository.DeleteBook(id);
            return Ok("ჩანაწერი წაიშალა");
        }

        [HttpPost]
        public async Task<IActionResult>CreateAuthor2Books(Author2BooksDTO author2BooksDTO)
        {
            var createauthor2books =await Author2BooksRepository.CreateAuthor2Books(author2BooksDTO);
            return Ok(createauthor2books);  
        }
        [HttpGet]
        public async Task<IActionResult> GetAuthor2Books()
        {
            var get2books=await Author2BooksRepository.GetAuthor2Books();   
            return Ok(get2books);
        }
        [HttpGet]
        public async Task<IActionResult>GetAuthor2Book(int id)
        {
            var get2book=await Author2BooksRepository.GetAuthor2Book(id);
            return Ok(get2book);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor2Book(UpdateAuthor2BooksDTO updateAuthor2BooksDTO)
        {
            var update2books=await Author2BooksRepository.UpdateAuthor2Books(updateAuthor2BooksDTO);
            return Ok(update2books);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor2Book(int id)
        {
            var delete2book=await Author2BooksRepository.DeleteAuthor2Books(id);
            return Ok("ჩანაწერი წაიშალა");
        }
    }
}
