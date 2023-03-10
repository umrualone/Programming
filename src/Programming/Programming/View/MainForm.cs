using System;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private object[] enums = new object[]
        {
            typeof(Color),
            typeof(Genre),
            typeof(EducationForm),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };
        
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
 
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;
        
        private Random _random = new Random();
        
        public MainForm()
        {
            InitializeComponent();

            FillRectangles(_rectangles);
            FillMovies(_movies);

            enumsListBox.Items.AddRange(enums);
            seasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
            
            enumsListBox.SelectedIndex = 0;
            seasonComboBox.SelectedIndex = 0;
            rectanglesListBox.SelectedIndex = 0;
            moviesListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enumsListBox.SelectedItem == null)
            {
                return;
            }
    
            var selectedEnum = (Type)enumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            valuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                valuesListBox.Items.Add(enumValue);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            intValueTextBox.Text = valuesListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(Weekday));
            var flag = false;
            foreach (var enumValue in enumValues)
            {
                var stringValue = enumValue.ToString();
                if (weekdayTextBox.Text == stringValue)
                {
                    flag = !flag;
                    resultParsingLabel.Text = $"Это день недели ({stringValue} = " +
                                              $"{(int)Enum.Parse(typeof(Weekday), stringValue)})";
                }
            }

            if (!flag)
                resultParsingLabel.Text = "Нет такого дня недели";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (seasonComboBox.Text)
            {
                case "Spring":
                    seasonGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Fall":
                    seasonGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }

        private void FillRectangles(Rectangle[] rectangles)
        {
            var colorValues = Enum.GetValues((Type)enums[0]);
            for (int i = 0; i < 5; i++)
            {
                int length = _random.Next(1, 30);
                int width = _random.Next(1, 30);
                string color = colorValues.GetValue(_random.Next(0, 6)).ToString();
                rectangles[i] = new Rectangle(length, width, color); 
            }
        }
        
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
            lengthTextBox.Text = _rectangles[rectanglesListBox.SelectedIndex].Length.ToString();
            widthTextBox.Text = _rectangles[rectanglesListBox.SelectedIndex].Width.ToString();
            colorTextBox.Text = _rectangles[rectanglesListBox.SelectedIndex].Color;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lengthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Length = Convert.ToDouble(lengthTextBox.Text);
            }
            catch
            {
                lengthTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                widthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Convert.ToDouble(widthTextBox.Text);
            }
            catch
            {
                widthTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
        
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = colorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int index = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }

            return index;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            rectanglesListBox.SelectedIndex = index;
        }
        
        private void FillMovies(Movie[] movies)
        {
            var genreValues = Enum.GetValues((Type)enums[1]);
            for (int i = 0; i < 5; i++)
            {
                int year = _random.Next(1900, 2024);
                int durationMinutes = _random.Next(1, 181);
                int rating = _random.Next(0, 11);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                movies[i] = new Movie($"Movie {i + 1}", durationMinutes, year, genre, rating); 
            }
        }
        
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[moviesListBox.SelectedIndex];

            titleTextBox.Text = _movies[moviesListBox.SelectedIndex].Title;
            yearTextBox.Text = _movies[moviesListBox.SelectedIndex].Year.ToString();
            timeTextBox.Text = _movies[moviesListBox.SelectedIndex].DurationMinutes.ToString();
            genreTextBox.Text = _movies[moviesListBox.SelectedIndex].Genre;
            ratingTextBox.Text = _movies[moviesListBox.SelectedIndex].Rating.ToString();
        }
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = titleTextBox.Text;
        }
        
        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                timeTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.DurationMinutes = Convert.ToInt32(timeTextBox.Text);
            }
            catch
            {
                timeTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
        
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yearTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Year = Convert.ToInt32(yearTextBox.Text);
            }
            catch
            {
                yearTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
        
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = genreTextBox.Text;
        }
        
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ratingTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Rating = Convert.ToInt32(ratingTextBox.Text);
            }
            catch
            {
                ratingTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
        
        private int FindMoviesWithMaxRating(Movie[] movies)
        {
            int index = 0;
            double maxRating = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int index = FindMoviesWithMaxRating(_movies);
            moviesListBox.SelectedIndex = index;
        }
    }
}