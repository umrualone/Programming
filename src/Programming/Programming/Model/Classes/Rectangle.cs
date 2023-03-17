namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public Rectangle() { }

        public double Length
        {
            get => _length;
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Длина должна быть больше нуля");
                }
                else
                {
                    _length = value;
                }
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Ширина должна быть больше нуля");
                }
                else
                {
                    _width = value;
                }
            }
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }
    }
}