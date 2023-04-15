namespace Programming.Model.Classes
{
        public class Rectangle
        {
            private double _length;
            private double _width;
            private string _color;
            public Point2D Center { get; private set; }
            private static int _allRectanglesCount = 0;
            private int _id;

            public Rectangle(double length, double width, string color, Point2D center)
            {
                Length = length;
                Width = width;
                Color = color;
                Center = center;
                _allRectanglesCount++;
                Id = _allRectanglesCount;
            }

            public Rectangle()
            {
                _allRectanglesCount++;
                Id = _allRectanglesCount;
            }

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

            public int AllRectanglesCount
            {
                get => _allRectanglesCount;
            }

            public int Id
            {
                get => _id;
                private set
                {
                    _id = value;
                }
            }
        }
}