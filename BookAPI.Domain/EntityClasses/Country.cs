using BookAPI.Domain.EntityClasses;

namespace BookAPI.Domain
{
    public class Country: BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
