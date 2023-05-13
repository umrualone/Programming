using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies = new Movie[5];
        /// <summary>
        /// Текущий выбранный фильм.
        /// </summary>
        private Movie _currentMovie;
        
        /// <summary>
        /// Экземпляр класса Random.
        /// </summary>
        private Random _random = new Random();
        
        public MoviesControl()
        {
            InitializeComponent();
            
            FillMovies(_movies);
            
            // Заполнение moviesListBox.
            var movies = new List<string>() {"Movie 1","Movie 2","Movie 3","Movie 4","Movie 5"};
            foreach (var movie in movies)
            {
                moviesListBox.Items.Add(movie);
            }
            
            moviesListBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Заполнение массива фильмов со случайными значениями.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        private void FillMovies(Movie[] movies)
        {
            var genreValues = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < 5; i++)
            {
                var year = _random.Next(1900, 2024);
                var durationMinutes = _random.Next(1, 181);
                var rating = _random.Next(0, 11);
                var genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                movies[i] = new Movie($"Movie {i + 1}", durationMinutes, year, genre, rating); 
            }
        }
        
        /// <summary>
        /// Выбор элемента в moviesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[moviesListBox.SelectedIndex];

            titleTextBox.Text = _currentMovie.Title;
            yearTextBox.Text = _currentMovie.Year.ToString();
            timeTextBox.Text = _currentMovie.DurationMinutes.ToString();
            genreTextBox.Text = _currentMovie.Genre;
            ratingTextBox.Text = _currentMovie.Rating.ToString();
        }
        
        /// <summary>
        /// Изменение данных в titleTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = titleTextBox.Text;
        }
        
        /// <summary>
        /// Изменение данных в timeTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                timeTextBox.BackColor = AppColors.NormalColor;
                _currentMovie.DurationMinutes = Convert.ToInt32(timeTextBox.Text);
            }
            catch
            {
                timeTextBox.BackColor = AppColors.ErrorColor;
            }
        }
        
        /// <summary>
        /// Изменение данных в yearTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yearTextBox.BackColor = AppColors.NormalColor;
                _currentMovie.Year = Convert.ToInt32(yearTextBox.Text);
            }
            catch
            {
                yearTextBox.BackColor = AppColors.ErrorColor;
            }
        }
        
        /// <summary>
        /// Изменение данных в genreTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = genreTextBox.Text;
        }
        
        /// <summary>
        /// Изменение данных в ratingTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ratingTextBox.BackColor = AppColors.NormalColor;
                _currentMovie.Rating = Convert.ToDouble(ratingTextBox.Text);
            }
            catch
            {
                ratingTextBox.BackColor = AppColors.ErrorColor;
            }
        }
        
        /// <summary>
        /// Возвращает индекс фильма с самым большим рейтингом. 
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Индекс.</returns>
        private static int FindMoviesWithMaxRating(Movie[] movies)
        {
            var index = 0;
            var maxRating = 0.0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (!(movies[i].Rating > maxRating)) continue;
                maxRating = movies[i].Rating;
                index = i;
            }
            return index;
        }

        /// <summary>
        /// Клик, который выбирает элемент с максимальным рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            var index = FindMoviesWithMaxRating(_movies);
            moviesListBox.SelectedIndex = index;
        }
    }
}