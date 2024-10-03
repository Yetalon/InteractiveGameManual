namespace InteractiveGameManual.Model{
    public class Character{
        /// <summary>
        /// health of the character
        /// </summary>
        public int Health{get; set;}
        /// <summary>
        /// power of the character
        /// </summary>
        public int Power{get; set;}
        /// <summary>
        /// image of the character ai generated
        /// https://chatgpt.com/g/g-pmuQfob8d-image-generator/c/66fe9bde-5528-8007-a6b9-5627677fe601
        /// </summary>
        public string? ImageURL{get; set;}
        /// <summary>
        /// Name of character
        /// </summary>
        public string? Name{get; set;}
        /// <summary>
        /// Description of character
        /// </summary>
        public string? Description{get; set;}
    }
}