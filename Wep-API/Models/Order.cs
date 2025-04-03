namespace Wep_API.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }  // Foreign key for Customer
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }

        // You can also add a reference to the Customer class here (optional)
         public Customer Customer { get; set; }
    }
}
