using InteractiveGameManual.Model;
namespace InteractiveGameManual.Services{
    public class NoteService{
        public List<Note>? AllNotes {get; set;}
        public NoteService(){
            AllNotes = new();
        }
        public void CreateNote(Note note){
            AllNotes.Add(note);
        }
        public void DeleteNote(Note note){
            AllNotes.Remove(note);
        }
    }
}