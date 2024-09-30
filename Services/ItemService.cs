using InteractiveGameManual.Model;
namespace InteractiveGameManual.Service{
    /// <summary>
    /// Simple abstract class for weapon and potion 
    /// provides a abstract method <see cref="GenerateName"/> and a formmatted string method <see cref="ToString"/>
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Name of an item
        /// </summary>
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public string ImageURL{get; set;}
        /// <summary>
        /// Initalizes a instance of <see cref="Item"/> generates a random name and sets the Type to none
        /// </summary>
        public Item()
        {
            ImageURL = "";
            Type = ItemType.None;
            Name = GenerateName();
        }
        /// <summary>
        /// used to randomly generate a name for a item
        /// </summary>
        /// <returns>a string for name</returns>
        public abstract string GenerateName();
        /// <summary>
        /// used to create a formatted string to display the item to the console
        /// </summary>
        /// <returns>formmated string of the item you picked up</returns>
        public override string ToString()
        {
            string temp = "";
            temp += $"you've picked up{Name}";
            return temp;
        }
    }
}