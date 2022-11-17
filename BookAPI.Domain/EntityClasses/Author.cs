using BookAPI.Domain.EntityClasses;

namespace BookAPI.Domain
{
    public class Author:BaseEntity
    {
        public string Name { get; set; } 
        public string SureName { get; set; }    
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public List<Book> Books { get; set; }
        public List<Author2Books> Author2Book { get; set; }

    }
}