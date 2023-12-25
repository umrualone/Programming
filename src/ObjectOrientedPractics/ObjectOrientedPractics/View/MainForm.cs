using System;
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
        private readonly Store _store = new Store();

        /// <summary>
        /// Создает экземпляр главного окна.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _store.Customers = Serializer.GetDataCustomers();
            _store.Items = Serializer.GetDataItems();


            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
            cartsTab.Customers = _store.Customers;
            cartsTab.Items = _store.Items;
            ordersTab.Customer = _store.Customers;

            itemsTab.RefreshData(0, EventArgs.Empty);
            customersTab.RefreshData(0, EventArgs.Empty);
            cartsTab.RefreshData(0, EventArgs.Empty);
            ordersTab.RefreshData(0, EventArgs.Empty);

            
            itemsTab.ItemsChanged += cartsTab.RefreshData;
            itemsTab.ItemsChanged += ordersTab.RefreshData;
            customersTab.CustomersChanged += cartsTab.RefreshData;
            customersTab.CustomersChanged += itemsTab.RefreshData;
            customersTab.CustomersChanged += ordersTab.RefreshData;
            cartsTab.CartsChanged += ordersTab.RefreshData;

        }
    }
}
