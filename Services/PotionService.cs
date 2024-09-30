using InteractiveGameManual.Model;
namespace InteractiveGameManual.Service{
    /// <summary>
    /// Inherits from <see cref="Item"/> abstract class
    /// Represents a potion item that can be a healing, damage, posion, or empty. 
    /// </summary>
    public class Potion : Item
    {
        /// <summary>
        /// The amount of healing, damage, or posion the potion will be
        /// </summary>
        public int EffectAmount { get; set; }
        /// <summary>
        /// the description of the potion
        /// </summary>
        string? EffectDescription { get; set; }
        /// <summary>
        /// A list of all the potion types
        /// </summary>
        List<ItemType> PotionTypes { get; set; }
        /// <summary>
        /// Random number generator for type
        /// </summary>
        Random Rnd { get; set; }
        /// <summary>
        /// Initalizes a instance of <see cref="potion"/> class
        /// Initalizes the list to have all the potion types, randomly picks a type, generates the name, sets the effect amount
        /// </summary>
        public Potion()
        {
            Rnd = new();
            PotionTypes = new() { ItemType.DamagePotion, ItemType.EmptyPotion, ItemType.HealingPotion, ItemType.PosionPotion };
            RandomType();
            Name = GenerateName();
            PotionEffect(Type);

        }
        /// <summary>
        /// Randomly picks a type and sets it
        /// </summary>
        public void RandomType()
        {
            Type = PotionTypes[Rnd.Next(PotionTypes.Count)];
        }
        /// <summary>
        /// Sets the potion name based on the type
        /// </summary>
        /// <returns>returns the potion name</returns>
        public override string GenerateName()
        {
            List<string> potionNames = new() { "Healing", "Damage", "Empty", "Poision" };
            switch (Type)
            {
                case ItemType.HealingPotion:
                    return potionNames[0];
                case ItemType.DamagePotion:
                    return potionNames[1];
                case ItemType.EmptyPotion:
                    return potionNames[2];
                case ItemType.PosionPotion:
                    return potionNames[3];
                default:
                    return "";
            }
        }
        /// <summary>
        /// sets the effect amount and description based on the potion type
        /// </summary>
        /// <param name="type">the type of potion</param>
        public void PotionEffect(ItemType type)
        {
            switch (type)
            {
                case ItemType.HealingPotion:
                    EffectAmount = 20;
                    EffectDescription = $"You heal for {EffectAmount}";
                    break;
                case ItemType.DamagePotion:
                    EffectAmount = 10;
                    EffectDescription = $"You take {EffectAmount} damage";
                    break;
                case ItemType.PosionPotion:
                    EffectAmount = 3;
                    EffectDescription = $"You have been posioned you take {EffectAmount} damage for the next 3 turns";
                    break;
                case ItemType.EmptyPotion:
                    EffectAmount = 0;
                    EffectDescription = $"how useless";
                    break;
                default:
                    EffectAmount = 0;
                    EffectDescription = "Unknown potion";
                    break;
            }
        }
        /// <summary>
        /// creates a formmated string
        /// </summary>
        /// <returns> a formatted string with the name of the potion picked up and the effect it has on the player</returns>
        public override string ToString()
        {
            string temp = "";
            temp += $"You have pick up a {Name} potion";
            temp += $"\n{EffectDescription}";
            return temp;
        }
    }
}