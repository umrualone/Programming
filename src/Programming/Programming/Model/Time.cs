public class Time
{
    private int hours;
    private int minutes;
    private int seconds;

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Time()
    {
        Hours = 0;
        Minutes = 0;
        Seconds = 0;
    }
    public int Hours
    {
        get => hours;
        set
        {
            if (value < 0 || value > 23)
            {
                throw new System.ArgumentException("Часы должны быть от 0 до 23");
            }
            else
            {
                hours = value;
            }
        }
    }

    public int Minutes
    {
        get => minutes;
        set
        {
            if (value < 0 || value > 60)
            {
                throw new System.ArgumentException("Минуты должны быть от 0 до 60");
            }
            else
            {
                minutes = value;
            }
        }
    }

    public int Seconds
    {
        get => seconds;
        set
        {
            if (value < 0 || value > 60)
            {
                throw new System.ArgumentException("Секунды должно быть от 0 до 60");
            }
            else
            {
                seconds = value;
            }
        }
    }
}
