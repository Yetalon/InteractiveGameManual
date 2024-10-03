using InteractiveGameManual.Model;

namespace InteractiveGameManual.Services{
    /// <summary>
    /// inherits the <see cref="ICharacter"/> interface and implements it along with adding two methods <see cref="Heal"/> <see cref="PlayerStatsToString"/>
    /// and creates a list<Weapons> for display and inventory management
    /// </summary>
    public class PlayerService : ICharacter{
        public List<Character> AllCharacters{get; set;}
        public List<Weapon> PlayerInventory { get; set; }
        /// <summary>
        /// tracks if player is posioned
        /// </summary>
        public bool IsPoisioned { get; set; }

        /// <summary>
        /// Sets players health to 20, power to 5, and creates the inventory
        /// </summary>
        public PlayerService(){
            AllCharacters = [];
            AllCharacters.Add(new Character{
                Health = 20,
                Power = 5,
                ImageURL = "https://files.oaiusercontent.com/file-k3fyrNnYNnvSYVtRB4LiEcM6?se=2024-10-03T13%3A33%3A36Z&sp=r&sv=2024-08-04&sr=b&rscc=max-age%3D604800%2C%20immutable%2C%20private&rscd=attachment%3B%20filename%3D1e873c2b-7c28-4608-a8e9-4fed54544955.webp&sig=B5Xr7w4w4kmuUFb5WjTiKXO5OC%2BF/8%2BP5WZsz4mrN/o%3D",
                Name = "Player",
                Description = "The player is a maze adventure whose one goal is to escape. The player starts with 20 health and 5 power; however, they can increase their power by finding weapons throughout the maze. The player must be careful, though. With only 20 max health, running into two damage potions could be a run-ender. There are many obstacles the player will run into during their adventure, and they must be fearful of what secrets lie in the maze."
            });
            PlayerInventory = new();
        }
        /// <summary>
        /// <see cref="ICharacter.AttackCharacter(ICharacter)"/>
        /// </summary>
        /// <param name="character"><see cref="ICharacter"/></param>
        public void AttackCharacter(ICharacter character){
            character.AllCharacters[0].Health -= AllCharacters[0].Power;
        }
        /// <summary>
        /// <see cref="ICharacter.DamageTaken(int)"/> 
        /// </summary>
        /// <param name="damage">an int representing damage to do</param>
        public void DamageTaken(int damage){
            AllCharacters[0].Health -= damage;
            if (AllCharacters[0].Health < 0){
                AllCharacters[0].Health = 0;
            }
        }
        /// <summary>
        /// Used when a healing potion is found takes amount to heal in a int and adds it to the players health
        /// if thhis is above 20 just sets the player health to 20
        /// </summary>
        /// <param name="healAmount"></param>
        public void Heal(int healAmount){
            AllCharacters[0].Health += healAmount;
            if (AllCharacters[0].Health > 20){
                AllCharacters[0].Health = 20;
            }
        }

        /// <summary>
        /// creates a formatted string to display as text in the printmaze
        /// </summary>
        /// <returns>A formatted string</returns>
        public string PlayerStatsToString(){
            string temp = "";
            temp += $"Health: {AllCharacters[0].Health}\n";
            temp += $"Power: {AllCharacters[0].Power}\n";
            temp += $"Posioned: {IsPoisioned}\n";
            temp += $"Items: \n";
            /*for (int i = 0; i > PlayerInventory.Count; i++){
                temp += $"{Weapon.AllItems[i].Name}";
            }*/
            return temp;
        }
    }
}