using BookAPI.Domain.EntityClasses;

namespace BookAPI.Domain
{
    public class Author:BaseEntity
    {
        public string Name { get; set; } 
        public string SureName { get; set; }    
        public Country Country { get; set; }
        public int CountryId { get; set; }
        //public ICollection<Book> Books { get; set; }
        public ICollection<Author2Books> Author2Books { get; set; }

    }
}