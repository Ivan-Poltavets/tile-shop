using Microsoft.EntityFrameworkCore;
using TileShop.Application.Profiles;
using TileShop.Application.Services;
using TileShop.Application.Services.Interfaces;
using TileShop.Domain.Repositories;
using TileShop.Infrastructure;
using TileShop.Infrastructure.Repositories;

namespace TileShop.API;

public static class ConfigureServices
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlite(configuration.GetConnectionString("DbConnection"));
        });
        services.AddAutoMapper(typeof(CategoryToDto));

        services.AddScoped<ICategoryService, CategoryService>();
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
    }
}
