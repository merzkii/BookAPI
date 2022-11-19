using BookAPI.Domain.EntityClasses;

namespace BookAPI.Domain
{
    public class Book: BaseEntity
    {
        public string Title { get; set; }
        public ICollection<Author2Books> Author2Books { get; set; }
    }
}
