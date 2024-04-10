using Microsoft.EntityFrameworkCore;
using TileShop.API.Categories.Requests;
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
        services.AddAutoMapper(typeof(CategoryToDto), typeof(CreateCategoryRequest));

        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IBasketService, BasketService>();
        services.AddScoped<IOrderService, OrderService>();
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICharacteristicsRepository, CharacteristicsRepository>();
        services.AddScoped<IBasketRepository, BasketRepository>();
        services.AddScoped<IBasketDetailsRepository, BasketDetailsRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
    }
}
