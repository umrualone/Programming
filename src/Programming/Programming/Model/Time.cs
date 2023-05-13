namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;
        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Создает экземпляр класса Time.
        /// </summary>
        /// <param name="hours">Часы. Должны быть в диапазоне от 0 до 23.</param>
        /// <param name="minutes">Минуты. Должны быть в диапазоне от 0 до 59.</param>
        /// <param name="seconds">Секунды. Должны быть в диапазоне от 0 до 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Создает экземпляр класса Time.
        /// </summary>
        public Time() { }
    
        /// <summary>
        /// Возвращает и задает часы. Должны быть в диапазоне от 0 до 23.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertValueInRange(value, nameof(Hours), 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает минуты. Должны быть в диапазоне от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, nameof(Minutes), 0, 59);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды. Должны быть в диапазоне от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, nameof(Seconds), 0, 59);
                _seconds = value;
            }
        }
    }   
}