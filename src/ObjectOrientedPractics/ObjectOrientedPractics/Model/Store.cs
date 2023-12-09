using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о магазине.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Создают экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store() 
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
