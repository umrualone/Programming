
public class Flight
{
    private string departurePoint;
    private string destination;
    private int flightTimeMinutes;

    public Flight(string departurePoint, string destination, int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }

    private Flight()
    {
        DeparturePoint = null;
        Destination = null;
        FlightTimeMinutes = 1;
    }
    public string DeparturePoint
    {
        get => departurePoint;
        set => departurePoint = value;
    }

    public string Destination
    {
        get => destination;
        set => destination = value;
    }

    public int FlightTimeMinutes
    {
        get => flightTimeMinutes;
        set
        {
            if (value <= 0)
                throw new System.ArgumentException("Время должно быть больше 0");
            else
                flightTimeMinutes = value;
        }
    }
}
