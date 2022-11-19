using BookAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAPI.Persistance.Config
{
    public class CountryConfig: IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasMany(x => x.Authors)
               .WithOne(x => x.Country)
               .HasForeignKey(x => x.CountryId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
    
}
