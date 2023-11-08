using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Интерфейс главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создает экземпляр главного окна.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            LoadingItems();
            LoadingCustomers();
        }

        /// <summary>
        /// Загрузка списка товаров.
        /// </summary>
        private void LoadingItems() 
        {
            _store.Items = Serializer.GetDataItems();
            itemsTab1.Items = _store.Items;


            if (itemsTab1.Items.Count > 0)
            {
               foreach (var item in itemsTab1.Items)
                {
                    itemsTab1.itemsListBox.Items.Add(item.Name);
                }
            }
        }

        /// <summary>
        /// Загрузка списка покупателей.
        /// </summary>
        private void LoadingCustomers()
        {
            _store.Customers = Serializer.GetDataCustomers();
            customersTab1.Customers = _store.Customers;

            if (customersTab1.Customers.Count > 0)
            {
                foreach (var customer in customersTab1.Customers)
                {
                    customersTab1.customersListBox.Items.Add(customer.FullName);
                }
            }
        }
    }
}
