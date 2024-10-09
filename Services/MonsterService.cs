using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    /// <summary>
    /// inherits the <see cref="ICharacter"/> and implements it and rolls random amont of health and power
    /// </summary>
    public class MonsterService : ICharacter{
        /// <summary>
        /// A list of all monsterCharacters
        /// </summary>
        public List<Character> AllCharacters {get; set;}
        /// <summary>
        /// Random number generator for monsters stats
        /// </summary>
        Random Rnd { get; set; }

        /// <summary>
        /// creates a instance of AllCharacters and then populates it with a monster.
        /// There is only one Monster in my maze but the health and power of the monster does change
        /// </summary>
        public MonsterService()
        {
            Rnd = new();
            AllCharacters = new();
            AllCharacters.Add(new Character{
                Health = Rnd.Next(6,11),
                Power = Rnd.Next(2,6),
                ImageURL = "https://raw.githubusercontent.com/Yetalon/Images/refs/heads/main/InteractiveGameManual/DALL%C2%B7E%202024-10-03%2009.30.00%20-%20A%20cartoony%20monster%20character%20for%20a%20maze%20game%2C%20designed%20in%20a%20playful%20and%20colorful%20style.%20The%20monster%20has%20a%20round%20body%20with%20exaggerated%20features%2C%20large%20.webp",
                Name = "Monster",
                Description = "The Monster is a dangerous beast that the player will encounter when trying to complete the Maze. The Monsters Health and Power are randomly generated, making each Monster unique and every battle unpredictable. A player may want to find a weapon before fighting a Monster."
            });

        }
        /// <summary>
        /// <see cref="ICharacter.AttackCharacter(ICharacter)"/>
        /// </summary>
        /// <param name="character"><see cref="ICharacter"/></param>
        public void AttackCharacter(ICharacter character)
        {
            //character.Health -= Power;
        }
        /// <summary>
        /// <see cref="ICharacter.DamageTaken(int)"/> 
        /// </summary>
        /// <param name="damage">an int representing damage to do</param>
        public void DamageTaken(int damage)
        {
            /*Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }*/
        }
    }
}