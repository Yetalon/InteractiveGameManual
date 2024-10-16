namespace InteractiveGameManual.Model{
    /// <summary>
    /// inherits from item and adds weapondamage as a stat for weapons
    /// </summary>
    public class Weapon : Item{
        /// <summary>
        /// Power of the weapon that will be added to the player
        /// </summary>
        public int WeaponDamage { get; set; }
    }
}