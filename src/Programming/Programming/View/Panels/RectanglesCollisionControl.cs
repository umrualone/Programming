using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;
        private List<Panel> _rectanglePanel = new List<Panel>();
        
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.Id}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Length})";
            
            return info;
        }
        
        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectangles[rectanglesListBox.SelectedIndex];

            idTextBox.Text = rectangle.Id.ToString();
            xTextBox.Text = rectangle.Center.X.ToString();
            yTextBox.Text = rectangle.Center.Y.ToString();
            widthTextBox.Text = rectangle.Width.ToString();
            lengthTextBox.Text = rectangle.Length.ToString();
        }
        
        private void ClearRectangleInfo()
        {
            idTextBox.Text = string.Empty;
            xTextBox.Text = string.Empty;
            yTextBox.Text = string.Empty;
            widthTextBox.Text = string.Empty;
            lengthTextBox.Text = string.Empty;
                
            xTextBox.BackColor = AppColors.NormalColor;
            yTextBox.BackColor = AppColors.NormalColor;
            widthTextBox.BackColor = AppColors.NormalColor;
            lengthTextBox.BackColor = AppColors.NormalColor;
        }
        
         private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize();
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);
            
            _rectangles.Add(rectangle);
            rectanglesListBox.Items.Add(info);
            
            panel.Height = Convert.ToInt32(rectangle.Length);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = AppColors.CollisionFalse;
            
            _rectanglePanel.Add(panel);
            rectanglesPanel.Controls.Add(panel);
            FindCollision();
        }
        
        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                _rectangles.RemoveAt(rectanglesListBox.SelectedIndex);
                _rectanglePanel.RemoveAt(rectanglesListBox.SelectedIndex);
                rectanglesPanel.Controls.RemoveAt(rectanglesListBox.SelectedIndex);
                rectanglesListBox.Items.RemoveAt(rectanglesListBox.SelectedIndex);
                FindCollision();
            }
            catch
            {
                // ignored
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                try
                {
                    UpdateRectangleInfo(ref _currentRectangle);
                }
                catch
                {
                    ClearRectangleInfo();
                }
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                xTextBox.BackColor = AppColors.NormalColor;
                
                var x = Convert.ToDouble(xTextBox.Text);
                var y = _currentRectangle.Center.Y;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangle);
                
                _currentRectangle.Center = coordinatePoint2D;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Location = coordinatePoint;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                xTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yTextBox.BackColor = AppColors.NormalColor;
                
                var x = _currentRectangle.Center.X;
                var y = Convert.ToDouble(yTextBox.Text);
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangle);
                
                _currentRectangle.Center = coordinatePoint2D;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Location = coordinatePoint;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                yTextBox.BackColor = AppColors.ErrorColor;
            }
        }   
        
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                widthTextBox.BackColor = AppColors.NormalColor;
                var widthDouble = Convert.ToDouble(widthTextBox.Text);
                var widthInt = Convert.ToInt32(widthTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangle);
                
                _currentRectangle.Width = widthDouble;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Width = widthInt;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                widthTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lengthTextBox.BackColor = AppColors.NormalColor;
                var lengthDouble = Convert.ToDouble(lengthTextBox.Text);
                var lengthInt = Convert.ToInt32(lengthTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangle);

                _currentRectangle.Length = lengthDouble;
                _rectanglePanel[rectanglesListBox.SelectedIndex].Height = lengthInt;
                rectanglesListBox.Items[rectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                lengthTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void FindCollision()
        {
            foreach (Panel rectangle in rectanglesPanel.Controls)
            {
                rectangle.BackColor = AppColors.CollisionFalse;
            }
            
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                    {
                        _rectanglePanel[i].BackColor = AppColors.CollisionTrue;
                        _rectanglePanel[j].BackColor = AppColors.CollisionTrue;
                    }
                }
            }
        }
    }
}