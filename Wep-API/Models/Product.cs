namespace Wep_API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public byte[] Image { get; set; }
        public int CategoryId { get; set; }  // Foreign key for Category

        // You can also add a reference to the Category class here (optional)
         public Category Category { get; set; }
    }
}
