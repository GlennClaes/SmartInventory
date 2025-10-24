namespace SmartInventory.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = string.Empty;

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentException("Price must be greater than zero.");
                _price = value;
            }
        }

        private int _stockQuantity;
        public int StockQuantity
        {
            get => _stockQuantity;
            private set
            {
                if (value < 0) throw new ArgumentException("StockQuantity cannot be negative.");
                _stockQuantity = value;
            }
        }

        public int ReorderLevel { get; set; }
        public string Category { get; set; } = string.Empty;

        public bool NeedsReorder => StockQuantity <= ReorderLevel;

        
        public void ReserveStock(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be positive.");
            if (quantity > StockQuantity) throw new InvalidOperationException("Not enough stock.");
            StockQuantity -= quantity;
        }

        public void AddStock(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be positive.");
            StockQuantity += quantity;
        }
    }
}
