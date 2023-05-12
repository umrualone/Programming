using System;
using System.IO;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class EnumerationsControl : UserControl
    {
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
            enumsListBox.Items.AddRange(_enums);
            enumsListBox.DisplayMember = nameof(FileInfo.Name);

            enumsListBox.SelectedIndex = 0;
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
    }
}