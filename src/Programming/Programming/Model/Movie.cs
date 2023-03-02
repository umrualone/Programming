public class Movie
{
    private string title;
    private int durationMinutes;
    private int released;
    private string genre;
    private double rating;


    public Movie(string title, int durationMinutes, int released, string genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        Released = released;
        Genre = genre;
        Rating = rating;
    }

    public Movie()
    {
        Title = null;
        DurationMinutes = 1;
        Released = 1900;
        Genre = null;
        Rating = 0;
    }
    public string Title
    {
        get => title;
        set => title = value;
    }

    public int DurationMinutes
    {
        get => durationMinutes;
        set
        {
            if (value <= 0)
                throw new System.ArgumentException("Время должно быть больше 0");
            else
                durationMinutes = value;
        }
    }

    public int Released
    {
        get => released;
        set
        {
            if (value < 1900 || value > 2023)
            {
                throw new System.ArgumentException("Дата должна быть от 1900 до текущего года");
            }
            else
            {
                released = value;
            }
        }
    }

    public string Genre
    {
        get => genre;
        set => genre = value;
    }

    public double Rating
    {
        get => rating;
        set
        {
            if (value < 0 || value > 10)
            {
                throw new System.ArgumentException("Оценка должна быть от 0 до 10");
            }
            else
            {
                rating = value;
            }
        }
    }
}
