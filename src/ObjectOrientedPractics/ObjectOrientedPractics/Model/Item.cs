using System;
using ObjectOrientedPractics.Services;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item: ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Названия товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описания товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        [JsonProperty("Id")]
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        [JsonProperty("Category")]
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает названия товара. Должно быть не более 200
        /// символов.
        /// </summary>
        [JsonProperty("Name")]
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, Name);
                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///  Возвращает и задает описания товара. Должно быть не более 1000
        ///  символов.
        /// </summary>
        [JsonProperty("Info")]
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, Info);
                _info = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара. Должно быть не более 100000.
        /// </summary>
        [JsonProperty("Cost")]
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Названия товара. Должно быть не более 200 символов.</param>
        /// <param name="category">Категория товара.</param>
        /// <param name="info">Описания товара. Должно быть не более 1000 символов.</param>
        /// <param name="cost">Цена товара. Должно быть не более 100000.</param>
        public Item(string name, Category category, string info, double cost)
        {
              
            Id = IdGenerator.GetNewIdItem();
            Name = name;
            Category = category;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>. Используются для десериализации JSON файла.
        /// </summary>
        /// <param name="id"></param>
        [JsonConstructor]
        public Item(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item() { }

        public object Clone()
        {
            var clone = new Item(this.Id)
            {
                Name = this.Name,
                Category = this.Category,
                Info = this.Info,
                Cost = this.Cost
            };
            return clone;
        }

        public bool Equals(Item other)
        {
           if (other == null) return false;

           return this.Name == other.Name;
        }

        public int CompareTo(Item other)
        {
            if (other == null) return 1;

            return this.Cost.CompareTo(other.Cost);
        }
    }
}