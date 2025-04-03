namespace Wep_API.Models
{
    public class Category
    {
        public int CategoryId { get; set; }  // Unique identifier for the category
        public string Name { get; set; }  // Name of the category

        // You can add additional properties here as needed, 
        // for example:
         public string Description { get; set; }  // Optional description of the category
         public List<Product> Products { get; set; }  // List of products in this category (optional)
    }
}
