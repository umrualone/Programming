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


            customersTab.Customers = _store.Customers;
            customersTab.RefreshData();

            itemsTab.Items = _store.Items;
            itemsTab.RefreshData();

            cartsTab.Customers = _store.Customers;
            cartsTab.Items = _store.Items;
            cartsTab.RefreshData();

            ordersTab.Customer = _store.Customers;
        }
        
        /// <summary>
        /// Событие переключение страниц.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlSelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 2:
                    cartsTab.RefreshData();
                    break;
                case 3:
                    ordersTab.UpdateOrders();
                    ordersTab.UpdateOrdersDataGridView();
                    break;
                default:
                    cartsTab.IndexComboBox();
                    break;
            }
        }
    }
}
