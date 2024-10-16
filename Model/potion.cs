namespace InteractiveGameManual.Model{
    /// <summary>
    /// inherits from item and adds effectdescription and effectamount for potions
    /// </summary>
    public class Potion : Item{
        /// <summary>
        /// the description of the potion
        /// </summary>
        public string? EffectDescription { get; set; }
        /// <summary>
        /// The amount of healing, damage, or posion the potion will be
        /// </summary>
        public int EffectAmount { get; set; }
    }
}