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
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();
        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;
        /// <summary>
        /// Список панелей прямоугольника.
        /// </summary>
        private List<Panel> _rectanglePanel = new List<Panel>();
        
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Возвращает строку с данными о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Строка с данными о прямоугольнике.</returns>
        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.Id}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Length})";
            
            return info;
        }
        
        /// <summary>
        /// Обновление данных в TextBox.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectangles[rectanglesListBox.SelectedIndex];

            idTextBox.Text = rectangle.Id.ToString();
            xTextBox.Text = rectangle.Center.X.ToString();
            yTextBox.Text = rectangle.Center.Y.ToString();
            widthTextBox.Text = rectangle.Width.ToString();
            lengthTextBox.Text = rectangle.Length.ToString();
        }
        
        /// <summary>
        /// Очистка данных в TextBox.
        /// </summary>
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
        
        /// <summary>
        /// Добавление нового прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize();
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);
            
            panel.Height = Convert.ToInt32(rectangle.Length);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = AppColors.CollisionFalse;
            
            // Добавление в списки и на экран приложения.
            _rectangles.Add(rectangle);
            rectanglesListBox.Items.Add(info);
            _rectanglePanel.Add(panel);
            rectanglesPanel.Controls.Add(panel);
            
            FindCollision();
        }
        
        /// <summary>
        /// Удаление выбранного прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Выбор элемента в rectanglesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Запрет на изменения idTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        /// <summary>
        /// Изменения данных в xTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Изменения данных в yTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// Изменения данных в widthTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Изменение данных в lengthTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Проверка на пересечение прямоугольников. В случаи пересечения, прямоугольники меняют свой цвет.
        /// </summary>
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