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
                    Validator.AssertOnPositiveValue(value, "Length");
                    _length = value;
                }
            }

            public double Width
            {
                get => _width;
                set
                {
                    Validator.AssertOnPositiveValue(value, "Width");
                    _width = value;
                }
            }

            public string Color
            {
                get => _color;
                set => _color = value;
            }
        }
}