public class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Time() { }
    
    public int Hours
    {
        get => _hours;
        set
        {
            if (value < 0 || value > 23)
            {
                throw new System.ArgumentException("Часы должны быть от 0 до 23");
            }
            else
            {
                _hours = value;
            }
        }
    }

    public int Minutes
    {
        get => _minutes;
        set
        {
            if (value < 0 || value > 60)
            {
                throw new System.ArgumentException("Минуты должны быть от 0 до 60");
            }
            else
            {
                _minutes = value;
            }
        }
    }

    public int Seconds
    {
        get => _seconds;
        set
        {
            if (value < 0 || value > 60)
            {
                throw new System.ArgumentException("Секунды должно быть от 0 до 60");
            }
            else
            {
                _seconds = value;
            }
        }
    }
}