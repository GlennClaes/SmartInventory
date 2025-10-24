namespace SmartInventory.Core.Entities
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int SupplierId { get; set; }
        public List<PurchaseOrderLine> Lines { get; set; } = new List<PurchaseOrderLine>();
    }
}
