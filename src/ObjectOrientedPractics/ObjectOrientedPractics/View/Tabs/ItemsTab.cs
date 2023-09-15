using System;
using ObjectOrientedPractics.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private List<Item> _items;
        
        /// <summary>
        /// 
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем item, иначе редактируем.
        /// </summary>
        private bool _flag = false;
       
        /// <summary>
        /// 
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            Serializer.IsCreateFolderAndFile();
            _items = Serializer.GetDataItems();

            if (_items.Count > 0)
            {
                foreach (var item in _items)
                {
                    itemsListBox.Items.Add(item.Name);
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
            costTextBox.ReadOnly = false;
            nameTextBox.ReadOnly = false;
            descriptionTextBox.ReadOnly = false;
            itemsListBox.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisabledTextBox()
        {
            costTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            itemsListBox.Enabled = true;
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
            itemsListBox.SelectedIndex = -1;
            EnabledVisibleButtonsAccept();
            EnabledTextBox();
            DisabledButtons();
            ClearTextBox();
            costTextBox.Text = "0";

            _flag = true;
        }

        private void AddItem()
        {
            var name = nameTextBox.Text;
            var description = descriptionTextBox.Text;
            var cost = Convert.ToDouble(costTextBox.Text);
            var item = new Item(name, description, cost);

            _items.Add(item);
            itemsListBox.Items.Add(item.Name);
            Serializer.UpdateData(_items);

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
            _currentItem.Name = nameTextBox.Text;
            _currentItem.Cost = Convert.ToDouble(costTextBox.Text);
            _currentItem.Info = descriptionTextBox.Text;

            _items[itemsListBox.SelectedIndex] = _currentItem;
            itemsListBox.Items[itemsListBox.SelectedIndex] = _currentItem.Name;

            Serializer.UpdateData(_items);

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
            _items.RemoveAt(itemsListBox.SelectedIndex);
            itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
            Serializer.UpdateData(_items);
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
            idTextBox.Text = _currentItem.Id.ToString();
            costTextBox.Text = _currentItem.Cost.ToString();
            nameTextBox.Text = _currentItem.Name;
            descriptionTextBox.Text = _currentItem.Info;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
            }
            else
            {
                _currentItem = _items[itemsListBox.SelectedIndex];
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
            costTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            costTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var cost = Convert.ToDouble(costTextBox.Text);
                costTextBox.BackColor = Color.White;

                ValueValidator.AssertValueInRange(cost, 0, 100000, nameof(cost));
                CheckAcceptButton();
            }
            catch
            {
                costTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var name = nameTextBox.Text;
                nameTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(name, 200, nameof(name));
                CheckAcceptButton();
            }
            catch
            {
                nameTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBoxTextChanged(object sender, EventArgs e)
        {
            try
            {
                var description = descriptionTextBox.Text;
                descriptionTextBox.BackColor = Color.White;
                ValueValidator.AssertStringOnLength(description, 1000, nameof(description));
                CheckAcceptButton();
            }
            catch
            {
                descriptionTextBox.BackColor = Color.Red;
                acceptButton.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckAcceptButton()
        {
            var cost = costTextBox.BackColor == Color.White;
            var name = nameTextBox.BackColor == Color.White;
            var description = descriptionTextBox.BackColor == Color.White;

            if (cost && name && description)
            {
                acceptButton.Enabled = true;
            }
        }
    }
}
