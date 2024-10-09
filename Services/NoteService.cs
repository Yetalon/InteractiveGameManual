using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    public class NoteService{
        /// <summary>
        /// Holds instances of all the notes created
        /// </summary>
        public List<Note> AllNotes {get; set;}
        /// <summary>
        /// used to hold all possible refrences to be made
        /// </summary>
        public List<string> AllRefrences {get; set;}
        /// <summary>
        /// 
        /// </summary>
        public NoteService(){
            AllNotes = new();
            AllRefrences = new();
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