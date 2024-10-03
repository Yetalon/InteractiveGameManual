using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    /// <summary>
    /// inherits the <see cref="ICharacter"/> and implements it and rolls random amont of health and power
    /// </summary>
    public class MonsterService : ICharacter{
        public List<Character> AllCharacters {get; set;}
        /// <summary>
        /// Random number generator for monsters stats
        /// </summary>
        Random Rnd { get; set; }

        /// <summary>
        /// randomly generates the health and power of the monster
        /// </summary>
        public MonsterService()
        {
            Rnd = new();
            AllCharacters = new();
            AllCharacters.Add(new Character{
                Health = Rnd.Next(6,11),
                Power = Rnd.Next(2,6),
                ImageURL = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png",
                Name = "Monster"
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