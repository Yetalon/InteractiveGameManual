using InteractiveGameManual.Model;

namespace InteractiveGameManual.Services{
    /// <summary>
    /// Simple Interface for any Character that forces them to have health and a power level along with the ability to attack a Character and 
    /// take damage from any source <see cref="AttackCharacter"/> <see cref="DamageTaken"/>
    /// </summary>
    public interface ICharacter{
        public List<Character> AllCharacters {get; set;}
        /// <summary>
        /// takens in a character(2) and subtracts the characters(2) health from the current characters power
        /// </summary>
        /// <param name="character"><see cref="ICharacter"/></param>
   
        void AttackCharacter(ICharacter character);
        /// <summary>
        /// Subtracts health from <see cref="damage"/> 
        /// </summary>
        /// <param name="damage">an int representing damage to do</param>
        void DamageTaken(int damage);
    }
}