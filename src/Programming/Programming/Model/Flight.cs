namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        /// <param name="departurePoint">Место отправления.</param>
        /// <param name="destination">Место назначения.</param>
        /// <param name="flightTimeMinutes">Время полета в минутах. Должно быть больше нуля.</param>
        public Flight(string departurePoint, string destination, int flightTimeMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        public Flight() { }
    
        /// <summary>
        /// Возвращает и задает место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает место назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета в минутах. Должно быть больше нуля.
        /// </summary>
        public int FlightTimeMinutes
        {
            get => _flightTimeMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeMinutes));
                _flightTimeMinutes = value;
            }
        }
    }
}