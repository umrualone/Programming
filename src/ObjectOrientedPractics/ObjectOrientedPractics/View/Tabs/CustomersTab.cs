using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers;

        /// <summary>
        /// 
        /// </summary>
        private Customer _currentCustomer;
        

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем item, иначе редактируем.
        /// </summary>
        private bool _flag = false;

        public CustomersTab()
        {
            InitializeComponent();

            _customers = Serializer.GetDataCustomers();

            if (_customers.Count > 0)
            {
                foreach (var customer in _customers)
                {
                    customersListBox.Items.Add(customer.FullName);
                }
            }
        }


        /// <summary>
        /// Включение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        public void EnabledVisibleButtonsAccept()
        {
            acceptButton.Visible = true;
            cancelButton.Visible = true;
        }

        /// <summary>
        /// Отключение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void DisabledVisibleButtonsAccept()
        {
            acceptButton.Visible = false;
            cancelButton.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void EnabledTextBox()
        {
            fullNameTextBox.ReadOnly = false;
            addressTextBox.ReadOnly = false;
            customersListBox.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisabledTextBox()
        {
            fullNameTextBox.ReadOnly = true;
            addressTextBox.ReadOnly = true;
            customersListBox.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void EnabledButtons()
        {
            addButton.Enabled = true;
            editButton.Enabled = false;
            removeButton.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisabledButtons()
        {
            addButton.Enabled = false;
            editButton.Enabled = false;
            removeButton.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, System.EventArgs e)
        {
            customersListBox.SelectedIndex = -1;
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();
            ClearTextBox();

            _flag = true;
        }

        private void AddItem()
        {
            var fullName = fullNameTextBox.Text;
            var address = addressTextBox.Text;
            var customer = new Customer(fullName, address);

            _customers.Add(customer);
            customersListBox.Items.Add(customer.FullName);
            Serializer.UpdateData(_customers);

            DisabledVisibleButtonsAccept();
            EnabledButtons();
            DisabledTextBox();
            ClearTextBox();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButtonClick(object sender, System.EventArgs e)
        {
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();

            _flag = false;
        }

        private void EditItem()
        {
            _currentCustomer.Address = addressTextBox.Text;
            _currentCustomer.FullName = fullNameTextBox.Text;

            _customers[customersListBox.SelectedIndex] = _currentCustomer;
            customersListBox.Items[customersListBox.SelectedIndex] = _currentCustomer.FullName;

            Serializer.UpdateData(_customers);

            DisabledVisibleButtonsAccept();
            EnabledButtons();
            DisabledTextBox();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            _customers.RemoveAt(customersListBox.SelectedIndex);
            customersListBox.Items.RemoveAt(customersListBox.SelectedIndex);
            Serializer.UpdateData(_customers);
            ClearTextBox();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptButtonClick(object sender, System.EventArgs e)
        {
            if (_flag)
            {
                AddItem();
            }
            else
            {
                EditItem();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (_flag)
            {
                EnabledButtons();
                DisabledTextBox();
                DisabledVisibleButtonsAccept();
                ClearTextBox();
            }
            else
            {
                EnabledButtons();
                DisabledTextBox();
                DisabledVisibleButtonsAccept();
                FillInfo();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        private void FillInfo()
        {
            idTextBox.Text = _currentCustomer.Id.ToString();
            fullNameTextBox.Text = _currentCustomer.FullName;
            addressTextBox.Text = _currentCustomer.Address;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex == -1)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
            }
            else
            {
                _currentCustomer = _customers[customersListBox.SelectedIndex];
                removeButton.Enabled = true;
                editButton.Enabled = true;
                FillInfo();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ClearTextBox()
        {
            idTextBox.Text = "";
            fullNameTextBox.Text = "";
            addressTextBox.Text = "";
        }


        /// <summary>
        /// 
        /// </summary>
        private void CheckAcceptButton()
        {
            var cost = fullNameTextBox.BackColor == Color.White;
            var name = addressTextBox.BackColor == Color.White;

            if (cost && name)
            {
                acceptButton.Enabled = true;
            }
        }

        private void FullNameTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var fullName = fullNameTextBox.Text;
                fullNameTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(fullName, 200, nameof(fullName));
                CheckAcceptButton();
            }
            catch
            {
                fullNameTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }

        private void AddressTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var address = addressTextBox.Text;
                addressTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(address, 500, nameof(address));
                CheckAcceptButton();
            }
            catch
            {
                addressTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }
    }
}
