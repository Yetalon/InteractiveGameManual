using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    /// <summary>
    /// Inherits from <see cref="Item"/> abstract class
    /// Represents a potion item that can be a healing, damage, posion, or empty. 
    /// </summary>
    public class PotionService : ItemService
    {

        /// <summary>
        /// A list of all the potion types
        /// </summary>
        List<ItemTypes> PotionTypes { get; set; }
        /// <summary>
        /// Random number generator for type
        /// </summary>
        Random Rnd { get; set; }
        /// <summary>
        /// Initalizes a instance of <see cref="potion"/> class
        /// Initalizes the list to have all the potion types, randomly picks a type, generates the name, sets the effect amount
        /// </summary>
        public PotionService()
        {
            Rnd = new();
            PotionTypes = new() { ItemTypes.DamagePotion, ItemTypes.EmptyPotion, ItemTypes.HealingPotion, ItemTypes.PosionPotion };
            AllItems = new();
            CreateAllPotions();
        }
        /// <summary>
        /// Randomly picks a type and sets it
        /// </summary>
        /*
        public void RandomType()
        {
            Type = PotionTypes[Rnd.Next(PotionTypes.Count)];
        }
        */
        /// <summary>
        /// Sets the potion name based on the type
        /// </summary>
        /// <returns>returns the potion name</returns>
        public override string GenerateName(Item potion)
        {
            List<string> potionNames = new() { "Healing", "Damage", "Empty", "Poision" };
            switch (potion.ItemType)
            {
                case ItemTypes.HealingPotion:
                    return potionNames[0];
                case ItemTypes.DamagePotion:
                    return potionNames[1];
                case ItemTypes.EmptyPotion:
                    return potionNames[2];
                case ItemTypes.PosionPotion:
                    return potionNames[3];
                default:
                    return "";
            }
        }
        /// <summary>
        /// sets the effect amount and description based on the potion type
        /// </summary>
        /// <param name="type">the type of potion</param>
        public void PotionEffect(Potion potion)
        {
            switch (potion.ItemType)
            {
                case ItemTypes.HealingPotion:
                    potion.EffectAmount = 20;
                    potion.EffectDescription = $"heals the player for {potion.EffectAmount} hp";
                    break;
                case ItemTypes.DamagePotion:
                    potion.EffectAmount = 10;
                    potion.EffectDescription = $"deals {potion.EffectAmount} damage to the player";
                    break;
                case ItemTypes.PosionPotion:
                    potion.EffectAmount = 3;
                    potion.EffectDescription = $"Posions the player causing {potion.EffectAmount} damage for the next 3 turns";
                    break;
                case ItemTypes.EmptyPotion:
                    potion.EffectAmount = 0;
                    potion.EffectDescription = $"a very very useless item";
                    break;
                default:
                    potion.EffectAmount = 0;
                    potion.EffectDescription = "Unknown potion";
                    break;
            }
        }
        public void CreateAllPotions(){
            foreach(var type in PotionTypes){
                Potion potion = new();
                potion.ItemType = type;
                PotionEffect(potion);
                potion.Name = GenerateName(potion);
                (potion.ImageURL, potion.Description) = PotionImage(potion);
                AllItems.Add(potion);
            } 
        }
        public (string, string) PotionImage(Potion potion){
            string imageURL = "";
            string description = "";
            switch(potion.ItemType){
                case ItemTypes.PosionPotion:
                    //https://clipart-library.com/search1/?q=posion+potion#gsc.tab=1&gsc.q=poison%20potion
                    imageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2Gpvt8ggwGqhqwngf1zWgcFsEK9D1e3GTcOg0RsLbEZt-oyM&s";
                    description ="The posion potion is quite the concotion damaging you over time. Running into one of can be a slow death. However, if you are lucky you may just run into a healing potion next to save your life.";
                    return (imageURL, description);
                case ItemTypes.DamagePotion:
                    //https://clipart-library.com/search1/?q=potion#gsc.tab=1&gsc.q=potion&gsc.page=1
                    imageURL = "https://clipart-library.com/2023/potion-bottle-clipart.png";
                    description =$"The damage potion is a truly scary potion with it dealing the most damage ({potion.EffectAmount} damage). You do not want to run into two of these at once player as it will end your run.";
                    return (imageURL, description);
                case ItemTypes.HealingPotion:
                    //https://clipart-library.com/search1/?q=potion#gsc.tab=1&gsc.q=potion&gsc.page=1
                    imageURL = "https://clipart-library.com/new_gallery/127-1270121_formao-do-neo-illustration.png";
                    description ="The healing potion is the one potion you will be hoping for the most. This potion will save your life many of time. One can only hope that every potion in the maze is a healing potion.";
                    return (imageURL, description);
                case ItemTypes.EmptyPotion:
                    //https://clipart-library.com/search1/?q=empty+potion#gsc.tab=1&gsc.q=empty%20potion&gsc.page=1
                    imageURL = "https://clipart-library.com/img1/422959.png";
                    description ="It's just a empty potion nothing more nothing less. While it may be the most useless potion in the game, you may be more happy to see it than anything else.";
                    return (imageURL, description);
                default:
                    return (imageURL, description);
            }
        }
        /// <summary>
        /// creates a formmated string
        /// </summary>
        /// <returns> a formatted string with the name of the potion picked up and the effect it has on the player</returns>
        /*public override string ToString()
        {
            string temp = "";
            temp += $"You have pick up a {Name} potion";
            temp += $"\n{EffectDescription}";
            return temp;
        }*/
    }
}