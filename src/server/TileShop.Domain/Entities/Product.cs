namespace TileShop.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string AccessImagesUrl { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int CharacteristicsId { get; set; }

    public virtual Category Category { get; set; } = new();
    public virtual Characteristics Characteristics { get; set; } = new();
}
