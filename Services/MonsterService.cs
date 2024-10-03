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
                ImageURL = "https://files.oaiusercontent.com/file-LyNvpvcbxkbkfy0H3UamE56q?se=2024-10-03T17%3A06%3A57Z&sp=r&sv=2024-08-04&sr=b&rscc=max-age%3D604800%2C%20immutable%2C%20private&rscd=attachment%3B%20filename%3Dcfb957f4-b24a-47eb-91df-d8a49bb905c0.webp&sig=a9Hewxvusk53jmq1YKqzaQcKcFYekzimEkY%2BcA0hRzE%3D",
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