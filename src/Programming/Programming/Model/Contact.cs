using System.Text.RegularExpressions;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о человеке и его контактных данных.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _firstName;
        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Создает экземпляр класса Contact. 
        /// </summary>
        /// <param name="firstName">Имя. Должно состоять только из
        /// букв.</param>
        /// <param name="lastName">Фамилия. Должна состоять только из
        /// букв.</param>
        /// <param name="number">Номер телефона.</param>
        public Contact(string firstName, string lastName, int number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        public Contact() { }
        
        
        /// <summary>
        /// Возвращает и задает имя человека. Должно состоять только
        /// из букв.
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(FirstName));
                _firstName = value;
            } 
        }

        /// <summary>
        /// Возвращает и задает фамилию человека. Должно состоять только
        /// из букв.
        /// </summary>
        public string LastName
        {
            get => _lastName;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(LastName));
                _lastName = value;  
            } 
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Проверяет, что строка состоит из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="name">Имя свойства, которая подлежит проверки.</param>
        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if (!regex.IsMatch(value))
            {
                throw new System.ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }
    }
}