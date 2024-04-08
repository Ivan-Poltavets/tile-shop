using Microsoft.EntityFrameworkCore;
using TileShop.Domain.Entities;

namespace TileShop.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Characteristics> Characteristics { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<BasketDetails> BasketDetails { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
}
