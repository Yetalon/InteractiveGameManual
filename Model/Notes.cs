namespace InteractiveGameManual.Model{
    /// <summary>
    /// model of what a note holds
    /// </summary>
    public class Note{
        /// <summary>
        /// The title of a note
        /// </summary>
        public string? Title {get; set;}
        /// <summary>
        /// the text of a note
        /// </summary>
        public string? Text{get; set;}
        /// <summary>
        /// any refrences for the note
        /// </summary>
        public List<string>? Refrences {get; set;}
    }
}