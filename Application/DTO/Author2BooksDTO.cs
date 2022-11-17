using BookAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Application.DTO
{
    public class Author2BooksDTO
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        
    }
}
