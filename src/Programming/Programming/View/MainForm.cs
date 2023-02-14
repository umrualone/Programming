using System;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        object[] enums = new object[] { typeof(Color), typeof(Genre), typeof(EducationForm), typeof(Manufactures), typeof(Season), typeof(Weekday) };
        
        public MainForm()
        {
            InitializeComponent();
            
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

        private void buttonParse_Click(object sender, EventArgs e)
        {
            string text = textBoxWeekday.Text;
            string[] weekdayValues = Enum.GetNames(typeof(Weekday));
            bool flag = false;
            for (int i = 0; i < weekdayValues.Length; i++)
            {
                if (text == weekdayValues[i])
                {
                    flag = !flag;
                    labelResult.Text = $"Это день недели ({weekdayValues[i]} = {i + 1})";
                }   
            }
            if (!flag)
                labelResult.Text = "Нет такого дня недели";
        }
    }
}