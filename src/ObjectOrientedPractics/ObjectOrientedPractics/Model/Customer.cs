using ObjectOrientedPractics.Services;
using System.Text.Json.Serialization;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Должно быть не более 200
        /// символов.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, FullName);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {

                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя. Должно быть не более 200 символов.</param>
        /// <param name="address">Адрес. Должен быть не более 500 символов</param>
        [JsonConstructor]
        public Customer(string fullName, Address address)
        {
            Id = IdGenerator.GetNewIdCustomer();
            FullName = fullName;
            Address = address;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer() { }
    }
}