namespace TileShop.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<OrderDetails> Details { get; set; } = new();
    }
}
