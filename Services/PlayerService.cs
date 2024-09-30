namespace InteractiveGameManual.Service{
    /// <summary>
    /// inherits the <see cref="ICharacter"/> interface and implements it along with adding two methods <see cref="Heal"/> <see cref="PlayerStatsToString"/>
    /// and creates a list<Weapons> for display and inventory management
    /// </summary>
    public class Player : ICharacter{
        /// <summary>
        /// players health
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// players power
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// List to store players items
        /// </summary>
        public List<Weapon> PlayerInventory { get; set; }
        /// <summary>
        /// tracks if player is posioned
        /// </summary>
        public bool IsPoisioned { get; set; }
        /// <summary>
        /// Sets players health to 20, power to 5, and creates the inventory
        /// </summary>
        public string ImageURL{get; set;}
        public Player(){
            ImageURL = "";
            Health = 20;
            Power = 5;
            PlayerInventory = new();
            IsPoisioned = false;
        }
        /// <summary>
        /// <see cref="ICharacter.AttackCharacter(ICharacter)"/>
        /// </summary>
        /// <param name="character"><see cref="ICharacter"/></param>
        public void AttackCharacter(ICharacter character){
            character.Health -= Power;
        }
        /// <summary>
        /// <see cref="ICharacter.DamageTaken(int)"/> 
        /// </summary>
        /// <param name="damage">an int representing damage to do</param>
        public void DamageTaken(int damage){
            Health -= damage;
            if (Health < 0){
                Health = 0;
            }
        }
        /// <summary>
        /// Used when a healing potion is found takes amount to heal in a int and adds it to the players health
        /// if thhis is above 20 just sets the player health to 20
        /// </summary>
        /// <param name="healAmount"></param>
        public void Heal(int healAmount){
            Health += healAmount;
            if (Health > 20){
                Health = 20;
            }
        }

        /// <summary>
        /// creates a formatted string to display as text in the printmaze
        /// </summary>
        /// <returns>A formatted string</returns>
        public string PlayerStatsToString(){
            string temp = "";
            temp += $"Health: {Health}\n";
            temp += $"Power: {Power}\n";
            temp += $"Posioned: {IsPoisioned}\n";
            temp += $"Items: \n";
            foreach (Item item in PlayerInventory)
            {
                temp += $"{item.Name}";
            }
            return temp;
        }
    }
}