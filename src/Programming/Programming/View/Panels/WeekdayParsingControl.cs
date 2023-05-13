using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Клик, который считывает текст из weekdayTextBox и проверяет есть ли такой день недели.
        /// Если он есть изменяет label "Это день недели ({имя дня} = {номер дня})", иначе "Нет такого дня недели" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(Weekday));
            var flag = false;
            foreach (var enumValue in enumValues)
            {
                var stringValue = enumValue.ToString();
                if (weekdayTextBox.Text != stringValue) continue;
                var day = (int)Enum.Parse(typeof(Weekday), stringValue); 
                flag = true;
                resultParsingLabel.Text = $@"Это день недели ({stringValue} = {day})";
                break;
            }

            if (!flag)
                resultParsingLabel.Text = @"Нет такого дня недели";
        }
    }
}