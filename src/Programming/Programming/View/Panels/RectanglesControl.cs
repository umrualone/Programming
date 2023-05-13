using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса RectanglesControl.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];
        
        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;
        
        /// <summary>
        /// Создает экземпляр класса RectanglesControl.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            FillRectangles(_rectangles);
            
            // Заполнение rectanglesListBox.
            var rectangles = new List<string>() {"Rectangle 1","Rectangle 2","Rectangle 3",
                "Rectangle 4","Rectangle 5"};
            foreach (var rectangle in rectangles)
            {
                rectanglesListBox.Items.Add(rectangle);
            }
            
            rectanglesListBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Заполнение массива прямоугольников случайными прямоугольниками.
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        private static void FillRectangles(Rectangle[] rectangles)
        {
            for (int i = 0; i < 5; i++)
            {
                rectangles[i] = RectangleFactory.Randomize();
            }
        }   
        
        /// <summary>
        /// Выбор элемента в rectanglesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                _currentRectangle.Length = Convert.ToDouble(lengthTextBox.Text);
            }
            catch
            {
                lengthTextBox.BackColor = AppColors.ErrorColor;
            }
        }
        
        /// <summary>
        /// Изменение данных в widthTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// Изменение данных в colorTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = colorTextBox.Text;
        }
        
        /// <summary>
        /// Запрет на изменение TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BanToChangeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        /// <summary>
        /// Возвращает индекс прямоугольника с самой большой шириной. 
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        /// <returns>Индекс.</returns>
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
        
        /// <summary>
        /// Обработчик, который выбирает элемент с максимальной шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            var index = FindRectangleWithMaxWidth(_rectangles);
            rectanglesListBox.SelectedIndex = index;
        }
    }
}