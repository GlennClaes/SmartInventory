namespace SmartInventory.Core.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
