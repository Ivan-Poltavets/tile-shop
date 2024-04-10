﻿using Microsoft.EntityFrameworkCore;
using TileShop.Domain.Entities;
using TileShop.Domain.Repositories;

namespace TileShop.Infrastructure.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context)
        : base(context) { }

    public override async Task<Product?> GetByIdAsync(int id)
    {
        return await EntitySet
            .Include(x => x.Characteristics)
            .Include(x => x.Category)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<Product>> GetByPriceRange(decimal minPrice, decimal maxPrice)
    {
        var products = await EntitySet
            .Where(x => x.Price >= minPrice && x.Price <= maxPrice)
            .AsNoTracking()
            .ToListAsync();
        return products;
    }

    public async Task<List<Product>> GetByPriceDescending()
    {
        var products = await EntitySet
            .OrderByDescending(x => x.Price)
            .AsNoTracking()
            .ToListAsync();
        return products;
    }

    public async Task<List<Product>> GetByPriceIncreasing()
    {
        var products = await EntitySet
            .Include(x => x.Characteristics)
            .Include(x => x.Category)
            .AsNoTracking()
            .ToListAsync();
        return products;
    }
}
