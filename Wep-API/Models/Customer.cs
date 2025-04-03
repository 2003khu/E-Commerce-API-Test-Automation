namespace Wep_API.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  // Hash the password before storing
        public string ShippingAddress { get; set; }

        // You can also add a list of Orders for this customer (optional)
         public List<Order> Orders { get; set; }
    }
}
