namespace SmartInventory.Core.Entities
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int QuantityChanged { get; set; }
        public string Reason { get; set; } = string.Empty;
    }
}
