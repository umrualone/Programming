using System;
using System.IO;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Массив перечислений.
        /// </summary>
        private object[] _enums = new object[]
        {
            typeof(Color),
            typeof(Genre),
            typeof(EducationForm),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };
        
        public EnumerationsControl()
        {
            InitializeComponent();
            
            // Заполнение enumsListBox всеми перечислениями.
            enumsListBox.Items.AddRange(_enums);
            enumsListBox.DisplayMember = nameof(FileInfo.Name);

            enumsListBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Изменения элементов valueListBox, при выборе другого элемента в EnumsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enumsListBox.SelectedItem == null)
            {
                return;
            }
    
            var selectedEnum = (Type)enumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            valuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                valuesListBox.Items.Add(enumValue);
            }
        }
        
        /// <summary>
        /// Запись индекса valuesListBox в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            intValueTextBox.Text = valuesListBox.SelectedIndex.ToString();
        }
    }
}