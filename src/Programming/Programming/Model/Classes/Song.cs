namespace Programming.Model.Classes
{ 
    public class Song
    {
        private string _author;
        private string _nameSong;
        private int _durationSeconds;

        public Song(string author, string nameSong, int durationSeconds)
        {
            Author = author;
            NameSong = nameSong;
            DurationSeconds = durationSeconds;
        }

        public Song() { }
    
        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public string NameSong
        {
            get => _nameSong;
            set => _nameSong = value;
        }

        public int DurationSeconds
        {
            get => _durationSeconds;
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Время должно быть больше 0");   
                }
                else
                {
                    _durationSeconds = value;   
                }
            }
        }
    }
}