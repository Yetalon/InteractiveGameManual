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
        /// Creates a instance of RND and AllItems and then Calls <see cref="CreateAllWeapons"/>
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
        /// <summary>
        /// Creates five instance of weapon randomly generated
        /// </summary>
        public void CreateAllWeapons(){
            for(int i = 0; i < 5; i++){
                Weapon weapon = new();
                weapon.ItemType = ItemTypes.Weapon;
                weapon.Name = GenerateName(weapon);
                weapon.WeaponDamage = Rnd.Next(1,11);
                (weapon.ImageURL , weapon.Description) = GenerateImageAndDescription(weapon);
                AllItems.Add(weapon);
            }
        }
        /// <summary>
        /// Takes off the prefix of the weapon to be able to generate a generalized description and image for the weapon.
        /// </summary>
        /// <param name="weapon">instance of weapon used to see what type of wepon it is</param>
        /// <returns></returns>
        public (string, string) GenerateImageAndDescription(Weapon weapon){
            string? name = weapon.Name;
            int spaceIndex = name.IndexOf(" ");
            name = name.Substring(spaceIndex + 1);
            string ImageURL = "";
            string Description = "";
            switch(name){
                case "Sword":
                    //take from opensource openclipart at https://openclipart.org/detail/8291/simple-sword
                     ImageURL = "https://openclipart.org/image/800px/8291";
                     Description = $"The {weapon.Name} is a basic weapon but effective. With its sharp blade, you will be able to slay tons of monsters. The sword may lead a path through the maze, but player be wary of the potions.";
                    return (ImageURL, Description);
                case "Axe":
                    //taken from opensource openclipart at https://openclipart.org/detail/17286/battle-axe-medieval
                    ImageURL = "https://openclipart.org/image/800px/17286";
                    Description = $"The {weapon.Name} is a great weapon to pick up in your adventure through the maze. It can be a powerful weapon in the right hands. While it may be heavy to lug around throughout the maze it's worth it.";
                    return (ImageURL, Description);
                case "Dagger":
                    //taken from opensource openclipart at https://openclipart.org/detail/170455/circassian-dagger
                    ImageURL = "https://openclipart.org/image/800px/170455";
                    Description = $"The {weapon.Name} is a lightweight and agile weapon. Whether you're retreating or running towards the monster it's great for quick maze navigation. The {weapon.Name} while small is stil a great weapon to pick up for slaying Monsters.";
                    return (ImageURL, Description);
                case "Spear":
                    //taken from opensource openclipart at https://openclipart.org/detail/249163/spear-2
                    ImageURL = "https://openclipart.org/image/800px/249163";
                    Description = $"The {weapon.Name} is a long pointy stick that may just save your life. if you are looking for a weapon that keeps the monsters at bay, then look no further. With the {weapon.Name} you'll be able to slay monsters easier than ever.(some may never even touch you)";
                    return (ImageURL, Description);
            }
            return (ImageURL, Description);
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