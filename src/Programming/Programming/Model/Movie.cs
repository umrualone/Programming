namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;
        /// <summary>
        /// Год выхода.
        /// </summary>
        private int _year;
        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;


        /// <summary>
        /// Создает экземпляр класса Movie.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationMinutes">Продолжительность фильма в минутах. Должна быть больше нуля.</param>
        /// <param name="year">Год выхода. Должен быть в диапазоне от 1900 до текущего года.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10.</param>
        public Movie(string title, int durationMinutes, int year, string genre, double rating)
        {
            Title = title;
            DurationMinutes = durationMinutes;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Создает экземпляр класса Movie.
        /// </summary>
        public Movie() { }
    
        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах. Должна быть больше нуля.
        /// </summary>
        public int DurationMinutes
        {
            get => _durationMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выхода. Должен быть в диапазоне от 1900 до текущего года.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(value, nameof(Year), 1900, 2023);
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть в диапазоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, nameof(Rating), 0, 10);
                _rating = value;
            }
        }
    }
}