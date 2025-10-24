using SmartInventory.Core.Enums;

namespace SmartInventory.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public int CustomerId { get; set; }

        public List<OrderLine> Lines { get; set; } = new List<OrderLine>();

        public decimal TotalAmount() => Lines.Sum(line => line.LineTotal());
    }
}
