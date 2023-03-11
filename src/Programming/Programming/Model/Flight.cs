public class Flight
{
    private string _departurePoint;
    private string _destination;
    private int _flightTimeMinutes;

    public Flight(string departurePoint, string destination, int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }

    public Flight() { }
    
    public string DeparturePoint
    {
        get => _departurePoint;
        set => _departurePoint = value;
    }

    public string Destination
    {
        get => _destination;
        set => _destination = value;
    }

    public int FlightTimeMinutes
    {
        get => _flightTimeMinutes;
        set
        {
            if (value <= 0)
            { 
                throw new System.ArgumentException("Время должно быть больше 0");   
            }
            else
            {
                _flightTimeMinutes = value;
            }
        }
    }
}