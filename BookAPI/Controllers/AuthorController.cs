using BookAPI.Application;
using BookAPI.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthorController : ControllerBase
    {
        public IAuthorRepository AuthorRepository { get; set; }
        public AuthorController(IAuthorRepository authorRepository)
        {
            AuthorRepository=authorRepository;
        }
        
        [HttpPost]
        public async Task<IActionResult>CreateAuthor(AuthorDTO authorDTO)
        {
            var createauthor=await AuthorRepository.CreateAuthor(authorDTO);
            return Ok(createauthor);
        }
        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var authors = await AuthorRepository.GetAuthors();
            return Ok(authors);
        }
        [HttpGet]
        public async Task<IActionResult>GetAuthor(int id)
        {
            var author = await AuthorRepository.GetAuthor(id);
            return Ok(author);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorsDTO updateauthorDTO)
        {
            var updateauthors=await AuthorRepository.UpdateAuthors(updateauthorDTO);
            return Ok(updateauthors);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor(int id) 
        { 
            var deleteauthor=await AuthorRepository.DeleteAuthor(id);
            return Ok("ჩანაწერი წაიშალა");
        }   

    }
}