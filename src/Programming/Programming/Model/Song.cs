namespace Programming.Model
{ 
    /// <summary>
    /// Хранит данные о песнях.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в минутах.
        /// </summary>
        private int _durationSeconds;

        /// <summary>
        /// Создает экземпляр класса Song.
        /// </summary>
        /// <param name="author">Автор.</param>
        /// <param name="nameSong">Название песни.</param>
        /// <param name="durationSeconds">Продолжительность песни в минутах. Должна быть больше нуля.</param>
        public Song(string author, string nameSong, int durationSeconds)
        {
            Author = author;
            NameSong = nameSong;
            DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Создает экземпляр класса Song.
        /// </summary>
        public Song() { }
    
        /// <summary>
        /// Возвращает и задает автора.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string NameSong { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность песни в минутах. Должна быть больше нуля.
        /// </summary>
        public int DurationSeconds
        {
            get => _durationSeconds;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationSeconds));
                _durationSeconds = value;
            }
        }
    }
}