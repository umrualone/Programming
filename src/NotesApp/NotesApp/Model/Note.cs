using System;
using System.Text.Json.Serialization;

namespace NotesApp.Model
{
    /// <summary>
    /// Хранит данные о записке.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Название записки. 
        /// </summary>
        private string _title;

        /// <summary>
        /// Создает экземпляр класса Note.
        /// </summary>
        /// <param name="title">Название записки.</param>
        /// <param name="description">Описание.</param>
        /// <param name="category">Категория.</param>
        public Note(string title, string description, string category)
        {
            Title = title;
            Description = description;
            Date = DateTime.Now.ToString();
            Category = category;
        }
        
        /// <summary>
        /// Создает экземпляр класса Note.
        /// </summary>
        /// <param name="title">Название записки.</param>
        /// <param name="description">Описание.</param>
        /// <param name="date">Время создания.</param>
        /// <param name="category">Категория.</param>
        [JsonConstructor]
        public Note(string title, string description, string date, string category)
        {
            Title = title;
            Description = description;
            Date = date;
            Category = category;
        }
        
        /// <summary>
        /// Возвращает и задает название записки. Длина названия не должна превышать 50 символов.
        /// </summary>
        /// <exception cref="ArgumentException">Символов не должно быть больше 50</exception>
        public string Title
        {
            get => _title;
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Символов не должно быть больше 50");
                }
                _title = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает описание записки.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Возвращает время создания записки
        /// </summary>
        public string Date { get; private set; }
        
        /// <summary>
        /// Возвращает и задает категорию записки.
        /// </summary>
        public string Category { get; set; }
    }
}