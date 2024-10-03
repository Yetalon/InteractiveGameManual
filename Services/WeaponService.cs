using System.Runtime.InteropServices;
using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    /// <summary>
    /// inherits from <see cref="Item"/> abstract class
    /// Represents a weapon itme that increases the players power
    /// </summary>
    public class WeaponService : ItemService{
        /// <summary>
        /// Random number generater to determine the weapon name and damage
        /// </summary>
        Random Rnd { get; set; }
        /// <summary>
        /// creates a instance of random and randomly generates the weapons damge
        /// Sets the type to weapon
        /// randomly generates name with <see cref="GenerateName"/>
        /// </summary>
        public WeaponService(){
            Rnd = new();
            AllItems = new();
            CreateAllWeapons();
        }
        /// <summary>
        /// randomly generates the name for the weapon picking a prefix and type of weapon
        /// </summary>
        /// <returns>the name for the weapoon</returns>
        public override string GenerateName(Item weapon){
            if(weapon.ItemType == ItemTypes.Weapon){
                Random Rnd = new();
                List<string> Prefixs = new() { "Legendary", "Cursed", "Mystical", "Rusted", "Energy" };
                List<string> TypeofWeapon = new() { "Sword", "Axe", "Dagger", "Spear" };
                string prefix = Prefixs[Rnd.Next(Prefixs.Count)];
                string weaponType = TypeofWeapon[Rnd.Next(TypeofWeapon.Count)];
                return $"{prefix} {weaponType}";
            }
            return "";
        }
        public void CreateAllWeapons(){
            for(int i = 0; i < 5; i++){
                Weapon weapon = new();
                weapon.ItemType = ItemTypes.Weapon;
                weapon.Name = GenerateName(weapon);
                weapon.WeaponDamage = Rnd.Next(1,11);
                weapon.ImageURL = GenerateImage(weapon);
                AllItems.Add(weapon);
            }
        }

        public string GenerateImage(Weapon weapon){
            string? name = weapon.Name;
            int spaceIndex = name.IndexOf(" ");
            name = name.Substring(spaceIndex + 1);
            switch(name){
                case "Sword":
                    //take from opensource openclipart at https://openclipart.org/detail/8291/simple-sword
                    return "https://openclipart.org/image/800px/8291";
                case "Axe":
                    //taken from opensource openclipart at https://openclipart.org/detail/17286/battle-axe-medieval
                    return "https://openclipart.org/image/800px/17286";
                case "Dagger":
                    //taken from opensource openclipart at https://openclipart.org/detail/170455/circassian-dagger
                    return "https://openclipart.org/image/800px/170455";
                case "Spear":
                    //taken from opensource openclipart at https://openclipart.org/detail/249163/spear-2
                    return "https://openclipart.org/image/800px/249163";
            }
            return "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png";
        }
        /// <summary>
        /// Creates a formatted string for the weapon
        /// </summary>
        /// <returns>A formatted string with the name of the weapon picked up and the damge increased by the weapon damge</returns>
        /*public override string ToString()
        {
            string temp = "";
            temp += $"You have picked up {Name}";
            temp += $"\nDamage increased by {WeaponDamage}";
            return temp;
        }*/
    }
}