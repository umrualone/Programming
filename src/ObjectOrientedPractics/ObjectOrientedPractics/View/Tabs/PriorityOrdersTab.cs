using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский интерфейс приоритетных заказов (Используется для тестов).
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Массив времени.
        /// </summary>
        private object[] _time =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает список.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Приоритетный заказ.
        /// </summary>
        private PriorityOrder _order;

        /// <summary>
        /// Конструктор <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            object[] orderStatus = Enum.GetNames(typeof(OrderStatus));
            statusComboBox.Items.AddRange(orderStatus);
            deliveryTimeComboBox.Items.AddRange(_time);
        }
        
        /// <summary>
        /// Событие выбора statusComboBox.
        /// </summary>
        private void StatusComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.Text);
        }

        /// <summary>
        /// Событие выбора deliveryTimeComboBox.
        /// </summary>
        private void DeliveryTimeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _order.DeliveryTime = deliveryTimeComboBox.Text;
        }

        /// <summary>
        /// Изменение amountCounterLabel.Text.
        /// </summary>
        private void UpdateAmmount()
        {
            amountCounterLabel.Text = _order.Amount.ToString();
        }

        /// <summary>
        /// Событие добавления случайного товара.
        /// </summary>
        private void AddButtonClick(object sender, EventArgs e)
        {
            var random = new Random();
            var index = random.Next(0, Items.Count);
            _order.Items.Add(Items[index]);
            itemsListBox.Items.Add(Items[index].Name);
            _order.Amount += Items[index].Cost;
            UpdateAmmount();
        }

        /// <summary>
        /// Событие удаления товара.
        /// </summary>
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            var index = itemsListBox.SelectedIndex;
            _order.Amount -= _order.Items[index].Cost;
            _order.Items.RemoveAt(index);
            itemsListBox.Items.RemoveAt(index);
            UpdateAmmount();
        }

        /// <summary>
        /// Событие очистки товаров.
        /// </summary>
        private void СlearButtonClick(object sender, EventArgs e)
        {
            _order.Items.Clear();
            itemsListBox.Items.Clear();
            _order.Amount = 0;
            UpdateAmmount();
            removeButton.Enabled = false;
        }

        /// <summary>
        /// Событие выбора itemsListBox.
        /// </summary>
        private void ItemsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = itemsListBox.SelectedIndex != -1;
        }

        /// <summary>
        /// Обновления заказа.
        /// </summary>
        public void UpdateOrders()
        {
            Random random = new Random();
            var index = random.Next(0, Customers.Count);
            _order = new PriorityOrder(Customers[index].Address, Customers[index].FullName, new List<Item>(), 0, "");
        }

        /// <summary>
        /// Обновление TextBox.
        /// </summary>
        public void UpdateTextBox()
        {
            idTextBox.Text = _order.Id.ToString();
            createdTextBox.Text = _order.CreatedDate.ToString();
            statusComboBox.Text = _order.Status.ToString();
            addressControl.Address = _order.Address;
            deliveryTimeComboBox.Text = _order.DeliveryTime;
            addressControl.FillInfo();
        }
    }
}
