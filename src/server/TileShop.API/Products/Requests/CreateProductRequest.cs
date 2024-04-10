using TileShop.Domain.Entities;

namespace TileShop.API.Products.Requests;

public class CreateProductRequest
{
    public string Name { get; set; } = string.Empty;
    public double DiscountInPercent { get; set; } = 0;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int CharacteristicsId { get; set; }
    public virtual Characteristics Characteristics { get; set; }
}
