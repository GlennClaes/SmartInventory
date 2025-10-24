
using SmartInventory.Core.ValueObjects;

namespace SmartInventory.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public Address BillingAddress { get; set; } = null!;
        public Address ShippingAddress { get; set; } = null!;
    }
}
