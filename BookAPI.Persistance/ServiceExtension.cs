using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BookAPI.Persistance;

namespace BookAPI.Infrastructure.Persistance
{

    public static class ServiceExtension
    {
        public static void AddPersistenceLayer(this IServiceCollection services)
        {

            //IServiceCollection serviceCollection = services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer("Server = localhost; Database = BaseBook; Trusted_Connection = True;",
            b => b.MigrationsAssembly("BookAPI")));
            //services.AddScoped<IImageService, FFImageLoading.ImageService>();

        }
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            //IServiceCollection serviceCollection = services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //services.AddScoped<IImageService, FFImageLoading.ImageService>();

        }
    }
}
