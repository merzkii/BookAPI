using BookAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAPI.Persistance.Config
{
    internal class Author2BooksConfig: IEntityTypeConfiguration<Author2Books>
    {
        public void Configure(EntityTypeBuilder<Author2Books> builder)
        {
            builder.HasOne(x => x.Author)
                .WithMany(x => x.Author2Books)
                .HasForeignKey(x => x.AuthorId);

            builder.HasOne(i => i.Book)
                .WithMany(i => i.Author2Books)
                .HasForeignKey(i => i.BookId);

        }
    }    
}
