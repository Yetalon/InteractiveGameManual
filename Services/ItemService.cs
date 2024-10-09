using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    /// <summary>
    /// Simple abstract class for weapon and potion 
    /// provides a abstract method <see cref="GenerateName"/> and a formmatted string method <see cref="ToString"/>
    /// </summary>
    public abstract class ItemService{
        /// <summary>
        /// A list of all the items <see cref="Item"/>
        /// </summary>
        public List<Item> AllItems{get; set;}
        /// <summary>
        /// Initalizes a instance AllItems
        /// </summary>
        public ItemService(){
            AllItems = new();
        }
        /// <summary>
        /// used to randomly generate a name for a item
        /// </summary>
        /// <returns>a string for name</returns>
        public abstract string GenerateName(Item item);
        /// <summary>
        /// used to create a formatted string to display the item to the console
        /// </summary>
        /// <returns>formmated string of the item you picked up</returns>
        public override string ToString(){
            string temp = "";
            for(int i = 0; i > AllItems.Count; i ++){
                temp += $"you've picked up{AllItems[i].Name}";
            }
            return temp;
        }
    }
}