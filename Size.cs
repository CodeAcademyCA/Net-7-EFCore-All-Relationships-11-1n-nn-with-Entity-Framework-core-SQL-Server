using System.Text.Json.Serialization;

namespace EFCoreRelationships
{
    
    public class Size
    {
        
        public int  Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
