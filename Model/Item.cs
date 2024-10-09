using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace InteractiveGameManual.Model{
    public class Item{
        /// <summary>
        /// Name of item
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// type of item
        /// </summary>
        public ItemTypes ItemType { get; set; }
        /// <summary>
        /// Image of item
        /// </summary>
        public string? ImageURL{get; set;}
        /// <summary>
        /// Description of the item
        /// </summary>
        public string? Description{get; set;}
    }
}