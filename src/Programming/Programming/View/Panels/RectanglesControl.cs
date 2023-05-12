using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;

namespace Programming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
        
        public RectanglesControl()
        {
            InitializeComponent();
  
            FillRectangles(_rectangles);
            
            var rectangles = new List<string>() {"Rectangle 1","Rectangle 2","Rectangle 3",
                "Rectangle 4","Rectangle 5"};
            foreach (var rectangle in rectangles)
            {
                rectanglesListBox.Items.Add(rectangle);
            }
            
            rectanglesListBox.SelectedIndex = 0;
        }
        
        private static void FillRectangles(Rectangle[] rectangles)
        {
            for (int i = 0; i < 5; i++)
            {
                rectangles[i] = RectangleFactory.Randomize();
            }
        }   
        
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
            
            lengthTextBox.Text = _currentRectangle.Length.ToString();
            classWidthTextBox.Text = _currentRectangle.Width.ToString();
            colorTextBox.Text = _currentRectangle.Color;
            xTextBox.Text = _currentRectangle.Center.X.ToString();
            yTextBox.Text = _currentRectangle.Center.Y.ToString();
            idTextBox.Text = _currentRectangle.Id.ToString();
        }
        
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lengthTextBox.BackColor = AppColors.NormalColor;
                _currentRectangle.Length = Convert.ToDouble(lengthTextBox.Text);
            }
            catch
            {
                lengthTextBox.BackColor = AppColors.ErrorColor;
            }
        }
        
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                classWidthTextBox.BackColor = AppColors.NormalColor;
                _currentRectangle.Width = Convert.ToDouble(classWidthTextBox.Text);
            }
            catch
            {
                classWidthTextBox.BackColor = AppColors.ErrorColor;
            }
        }
        
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = colorTextBox.Text;
        }
        
        private void BanToChangeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            var index = 0;
            var maxWidth = 0.0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (!(rectangles[i].Width > maxWidth)) continue;
                maxWidth = rectangles[i].Width;
                index = i;
            }

            return index;
        }
        
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            var index = FindRectangleWithMaxWidth(_rectangles);
            rectanglesListBox.SelectedIndex = index;
        }
    }
}