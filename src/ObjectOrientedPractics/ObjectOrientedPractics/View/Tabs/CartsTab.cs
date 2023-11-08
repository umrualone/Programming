using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Item _currentItem;

        private Customer _currentCustomer;

        public List<Item> Items {  get; set; }

        public List<Customer> Customers { get; set; }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void ItemsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem = Items[itemsListBox.SelectedIndex];
                CheckingEnablingButtons();
            }
            catch { }
        }

        private void CustomersComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer = Customers[customersComboBox.SelectedIndex];
                CheckingEnablingButtons();
                CartListUpdate();
                AmmountTest();
                CheckingEnablingButtons();
            }
            catch 
            {
                cartListBox.Items.Clear();
                label5.Text = "0";
                CheckingEnablingButtons();
            }
            
        }

        private void CartListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                removeItemButton.Enabled = true;
            }
            else
            {
                removeItemButton.Enabled=false;
            }
        }

        private void AddToCartButtonClick(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Add(_currentItem);
            //Customers[customersComboBox.SelectedIndex] = _currentCustomer;
            Serializer.UpdateData(Customers);
            CartListUpdate();
            AmmountTest();
            CheckingEnablingButtons();
        }

        private void CreateOrderButtonClick(object sender, EventArgs e)
        {
            Order order = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items, _currentCustomer.Cart.Amount);
            _currentCustomer.Orders.Add(order);
            _currentCustomer.Cart = new Cart();
            //Customers[customersComboBox.SelectedIndex] = _currentCustomer;
            Serializer.UpdateData(Customers);
            CartListUpdate();
            AmmountTest();
            CheckingEnablingButtons();
        }

        private void RemoveItemButtonClick(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.RemoveAt(cartListBox.SelectedIndex);
           // Customers[customersComboBox.SelectedIndex] = _currentCustomer;
            Serializer.UpdateData(Customers);
            CartListUpdate();
            AmmountTest();
            removeItemButton.Enabled = false;
            CheckingEnablingButtons();
        }

        private void ClearCartButtonClick(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Clear();
            //Customers[customersComboBox.SelectedIndex] = _currentCustomer;
            Serializer.UpdateData(Customers);
            CartListUpdate();
            AmmountTest();
            CheckingEnablingButtons();
        }

        private void CheckingEnablingButtons()
        {
            if (itemsListBox.SelectedIndex != -1 && customersComboBox.SelectedIndex != -1)
            {
                addToCartButton.Enabled = true;
            }
            else
            {
                addToCartButton.Enabled = false;
            }

            if (cartListBox.Items.Count > 0)
            {
                clearCartButton.Enabled = true;
                createOrderButton.Enabled = true;
            }
            else
            {
                clearCartButton.Enabled = false;
                createOrderButton.Enabled = false;
            }
        }
    
        public void CartListUpdate()
        {
            cartListBox.Items.Clear();
            for (int i = 0; i < _currentCustomer.Cart.Items.Count; i++)
            {
                cartListBox.Items.Add(_currentCustomer.Cart.Items[i].Name);
            }
        }

        public void AmmountTest()
        {
           label5.Text = _currentCustomer.Cart.Amount.ToString();
        }

        public void RefreshData()
        {
            itemsListBox.Items.Clear();
            if (Items.Count > 0)
            {
                foreach (var item in Items)
                {
                    itemsListBox.Items.Add(item.Name);
                }
            }

            customersComboBox.Items.Clear();
            if (Customers.Count > 0)
            {
                foreach (var customer in Customers)
                {
                    customersComboBox.Items.Add(customer.FullName);
                }
            }
        }
    }
}
