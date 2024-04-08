namespace TileShop.Domain.Entities;

public class Basket
{
    public int Id { get; set; }
    public List<BasketDetails> Items { get; set;} = new();
}
