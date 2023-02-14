using System;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        
        
        public MainForm()
        {
            InitializeComponent();
            
            object[] enums = new object[] { typeof(Color), typeof(Genre), typeof(EducationForm), typeof(Manufactures), typeof(Season), typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
        }
        
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem == null)
            {
                return;
            }

            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxValue.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}