namespace Programming.Model.Classes
{
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
                Validator.AssertOnPositiveValue(value, "FlightTimeMinutes");
                _durationMinutes = value;
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(value, "Year", 1900, 2023);
                _year = value;
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
                Validator.AssertValueInRange(value, "Rating", 0, 10);
                _rating = value;
            }
        }
    }
}