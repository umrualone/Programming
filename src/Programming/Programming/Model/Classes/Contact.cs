using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private int _number;

        public Contact(string firstName, string lastName, int number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public Contact() { }
    
        public string FirstName
        {
            get => _firstName;
            set
            {
                AssertStringContainsOnlyLetters(value, "Name");
                _firstName = value;
            } 
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                AssertStringContainsOnlyLetters(value, "Last name");
                _lastName = value;  
            } 
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

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