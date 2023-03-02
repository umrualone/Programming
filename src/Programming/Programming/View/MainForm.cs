using System;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private object[] enums = new object[]
        {
            typeof(Color),
            typeof(Genre),
            typeof(EducationForm),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };
        private Rectangle[] _rectangles = new Rectangle[5];
        private Random _random = new Random();
        public MainForm()
        {
            InitializeComponent();
            
            for (int i = 0; i < 5; i++)
            {
                var colorValues = Enum.GetValues(typeof(Color));
                double length = _random.NextDouble() * 10 + 1; // длина от 1 до 11
                double width = _random.NextDouble() * 10 + 1; // ширина от 1 до 11
                string color = colorValues.GetValue(_random.Next(0, 6)).ToString();
                _rectangles[i] = new Rectangle(length, width, color);
            }
            enumsListBox.Items.AddRange(enums);
            seasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
            enumsListBox.SelectedIndex = 0;
            seasonComboBox.SelectedIndex = 0;
        }
        
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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            intValueTextBox.Text = valuesListBox.SelectedIndex.ToString();
        }
        
        private void ParseButton_Click(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(Weekday));
            var flag = false;
            foreach (var enymValue in enumValues)
            {
                var stringValue = enymValue.ToString();
                if (weekdayTextBox.Text == stringValue)
                {
                    flag = !flag;
                    resultParsingLabel.Text = $"Это день недели ({stringValue} = " +
                                         $"{(int)Enum.Parse(typeof(Weekday), stringValue)})";
                }       
            }
            if (!flag)
                resultParsingLabel.Text = "Нет такого дня недели";
        }
        
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (seasonComboBox.Text)
            {
                case "Spring":
                    seasonGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Fall":
                    seasonGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
            }
        }
    }
}