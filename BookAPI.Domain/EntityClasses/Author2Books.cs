using BookAPI.Domain.EntityClasses;

namespace BookAPI.Domain
{
    public class Author2Books:BaseEntity
    {
        public Book Book { get; set; }
        public int BookId { get; set; } 
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
