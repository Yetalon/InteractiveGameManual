using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    /// <summary>
    /// Holds all the notes created and manages them with CreateNote and DeleteNote methods
    /// Also holds all possible refrences
    /// </summary>
    public class NoteService{
        /// <summary>
        /// Holds all the notes created
        /// </summary>
        public List<Note> AllNotes {get; set;}
        /// <summary>
        /// used to hold all possible refrences to be made
        /// </summary>
        public List<string> AllRefrences {get; set;}
        public int EmptyTitle {get; set;}
        /// <summary>
        /// Creates a instance of <see cref="AllNotes"/> and a instance of <see cref="AllRefrences"/> and sets the amount of empty titles to 0
        /// </summary>
        public NoteService(){
            AllNotes = new();
            AllRefrences = new();
            EmptyTitle = 0;
        }
        /// <summary>
        /// adds a note to the allnotes list
        /// </summary>
        /// <param name="note">Note to be added to all notes</param>
        public void CreateNote(Note note){
            AllNotes.Add(note);
        }
        /// <summary>
        /// Deletes a selected note
        /// </summary>
        /// <param name="note">note to be deleted from all notes</param>
        public void DeleteNote(Note note){
            AllNotes.Remove(note);
        }
        /// <summary>
        /// Populates <see cref="AllRefrences"/> with every possible refrence to a character or item
        /// </summary>
        /// <param name="Player">All the players</param>
        /// <param name="Monster">All the monster</param>
        /// <param name="Weapons">all the weapons</param>
        /// <param name="Potions">All the potions</param>
        public void InitalizeAllRefrences(PlayerService Player, MonsterService Monster, WeaponService Weapons, PotionService Potions){
            if(AllRefrences.Count >= 11){
                return;
            }
            else{
            foreach(var player in Player.AllCharacters){
                AllRefrences.Add(player.Name);
            }
            foreach(var monster in Monster.AllCharacters){
                AllRefrences.Add(monster.Name);
            }
            foreach(var weapon in Weapons.AllItems){
                AllRefrences.Add(weapon.Name);
            }
            foreach(var potion in Potions.AllItems){
                AllRefrences.Add(potion.Name);
            }
            }
        }
    }
}