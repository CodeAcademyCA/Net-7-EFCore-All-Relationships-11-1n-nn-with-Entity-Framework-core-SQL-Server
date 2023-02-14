using System.Text.Json.Serialization;

namespace EFCoreRelationships
{
    public class Product
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public double  Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        
        public Size Size { get; set; }
        
        public List<Color> Colors { get; set; }
    }
}
