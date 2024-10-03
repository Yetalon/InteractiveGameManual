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
                    potion.EffectDescription = $"You heal for {potion.EffectAmount}";
                    break;
                case ItemTypes.DamagePotion:
                    potion.EffectAmount = 10;
                    potion.EffectDescription = $"You take {potion.EffectAmount} damage";
                    break;
                case ItemTypes.PosionPotion:
                    potion.EffectAmount = 3;
                    potion.EffectDescription = $"You have been posioned you take {potion.EffectAmount} damage for the next 3 turns";
                    break;
                case ItemTypes.EmptyPotion:
                    potion.EffectAmount = 0;
                    potion.EffectDescription = $"how useless";
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
                potion.ImageURL = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png";
                AllItems.Add(potion);
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