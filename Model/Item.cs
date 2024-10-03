using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace InteractiveGameManual.Model{
    public class Item{
        public string? Name { get; set; }
        public ItemTypes ItemType { get; set; }
        public string? ImageURL{get; set;}
        public string? Description{get; set;}
    }
}