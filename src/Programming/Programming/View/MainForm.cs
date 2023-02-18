using System;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        object[] enums = new object[]
        {
            typeof(Color),
            typeof(Genre),
            typeof(EducationForm),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };
        
        public MainForm()
        {
            InitializeComponent();
            
            EnumsListBox.Items.AddRange(enums);
            SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));

            EnumsListBox.SelectedIndex = 0;
            SeasonComboBox.SelectedIndex = 0;
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
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
        
        private void ParseButton_Click(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(Weekday));
            var flag = false;
            foreach (var enymValue in enumValues)
            {
                var stringValue = enymValue.ToString();
                if (WeekdayTextBox.Text == stringValue)
                {
                    flag = !flag;
                    ResultParsing.Text = $"Это день недели ({stringValue} = " +
                                         $"{(int)Enum.Parse(typeof(Weekday), stringValue)})";
                }       
            }
            if (!flag)
                ResultParsing.Text = "Нет такого дня недели";
        }
        
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Spring":
                    SeasonGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Fall":
                    SeasonGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }
    }
}