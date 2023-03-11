public class Movie
{
    private string _title;
    private int _durationMinutes;
    private int _year;
    private string _genre;
    private double _rating;


    public Movie(string title, int durationMinutes, int year, string genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        Year = year;
        Genre = genre;
        Rating = rating;
    }

    public Movie() { }
    
    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public int DurationMinutes
    {
        get => _durationMinutes;
        set
        {
            if (value <= 0)
            {
                throw new System.ArgumentException("Время должно быть больше 0");
            }
            else
            {
                _durationMinutes = value;   
            }
        }
    }

    public int Year
    {
        get => _year;
        set
        {
            if (value < 1900 || value > 2023)
            {
                throw new System.ArgumentException("Дата должна быть от 1900 до текущего года");
            }
            else
            {
                _year = value;
            }
        }
    }

    public string Genre
    {
        get => _genre;
        set => _genre = value;
    }

    public double Rating
    {
        get => _rating;
        set
        {
            if (value < 0 || value > 10)
            {
                throw new System.ArgumentException("Оценка должна быть от 0 до 10");
            }
            else
            {
                _rating = value;
            }
        }
    }
}