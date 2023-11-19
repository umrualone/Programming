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
            _store.Customers = Serializer.GetDataCustomers();
            _store.Items = Serializer.GetDataItems();


            customersTab1.Customers = _store.Customers;
            customersTab1.RefreshData();

            itemsTab1.Items = _store.Items;
            itemsTab1.RefreshData();

            cartsTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.RefreshData();

            ordersTab.Customer = _store.Customers;
        }
        
        /// <summary>
        /// Событие переключение страниц.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlSelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (ordersTabControl.SelectedIndex)
            {
                case 2:
                    cartsTab1.RefreshData();
                    break;
                case 3:
                    ordersTab.UpdateOrders();
                    ordersTab.UpdateOrdersDataGridView();
                    break;
                default:
                    cartsTab1.IndexComboBox();
                    break;
            }
        }
    }
}
