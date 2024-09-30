using InteractiveGameManual.Model;
namespace InteractiveGameManual.Service{
    /// <summary>
    /// inherits from <see cref="Item"/> abstract class
    /// Represents a weapon itme that increases the players power
    /// </summary>
    public class Weapon : Item
    {
        /// <summary>
        /// Power of the weapon that will be added to the player
        /// </summary>
        public int WeaponDamage { get; set; }
        /// <summary>
        /// Random number generater to determine the weapon name and damage
        /// </summary>
        Random Rnd { get; set; }
        /// <summary>
        /// creates a instance of random and randomly generates the weapons damge
        /// Sets the type to weapon
        /// randomly generates name with <see cref="GenerateName"/>
        /// </summary>
        public Weapon()
        {
            Rnd = new();
            WeaponDamage = Rnd.Next(1, 11);
            Type = ItemType.Weapon;
            Name = GenerateName();
        }
        /// <summary>
        /// randomly generates the name for the weapon picking a prefix and type of weapon
        /// </summary>
        /// <returns>the name for the weapoon</returns>
        public override string GenerateName()
        {
            Random Rnd = new();
            List<string> Prefixs = new() { "Legendary", "Cursed", "Mystical", "Rusted", "Energy" };
            List<string> TypeofWeapon = new() { "Sword", "Axe", "Dagger", "Spear" };
            string prefix = Prefixs[Rnd.Next(Prefixs.Count)];
            string weaponType = TypeofWeapon[Rnd.Next(TypeofWeapon.Count)];
            return $"{prefix} {weaponType}";
        }
        /// <summary>
        /// Creates a formatted string for the weapon
        /// </summary>
        /// <returns>A formatted string with the name of the weapon picked up and the damge increased by the weapon damge</returns>
        public override string ToString()
        {
            string temp = "";
            temp += $"You have picked up {Name}";
            temp += $"\nDamage increased by {WeaponDamage}";
            return temp;
        }
    }
}