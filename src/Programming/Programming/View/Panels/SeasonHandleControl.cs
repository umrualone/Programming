using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            
            var items = Enum.GetNames(typeof(Season));    
            
            // Заполнение seasonComboBox.
            seasonComboBox.Items.AddRange(items);
            seasonComboBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Клик, который выводит сообщение в зависимости от выбранного времени года в seasonComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (seasonComboBox.Text)
            {
                case "Spring":
                {
                    MessageBox.Show(@"А вот и весна!");
                    break;
                }
                case "Summer":
                {
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                }
                case "Fall":
                {
                    MessageBox.Show(@"Ух ты! Осень!");
                    break;
                }
                case "Winter":
                {
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                }
            }
        }
    }
}