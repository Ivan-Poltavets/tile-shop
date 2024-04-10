using TileShop.Domain.Entities;

namespace TileShop.Domain.Dtos;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string AccessImagesUrl { get; set; } = string.Empty;
    public double Discount { get; set; } = 0;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int CharacteristicsId { get; set; }

    public virtual Category? Category { get; set; }
    public virtual Characteristics? Characteristics { get; set; }
}
