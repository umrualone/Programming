public class Song
{
    private string author;
    private string nameSong;
    private int durationSeconds;

    public Song(string author, string nameSong, int durationSeconds)
    {
        Author = author;
        NameSong = nameSong;
        DurationSeconds = durationSeconds;
    }

    public Song()
    {
        Author = null;
        NameSong = null;
        durationSeconds = 1;
    }
    public string Author
    {
        get => author;
        set => author = value;
    }

    public string NameSong
    {
        get => nameSong;
        set => nameSong = value;
    }

    public int DurationSeconds
    {
        get => durationSeconds;
        set
        {
            if (value <= 0)
                throw new System.ArgumentException("Время должно быть больше 0");
            else
                durationSeconds = value;
        }
    }
}
