namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle 
    { 
        /// <summary>
        /// Высота.
        /// </summary>
        private double _length; 
        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;
        /// <summary>
        /// Количество созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        /// <param name="length">Высота. Должна быть больше нуля.</param>
        /// <param name="width">Ширина. Должны быть больше нуля.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса Rectangle.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть больше нуля.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }
        
        /// <summary>
        /// Возвращает и задает координаты прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }
        
        /// <summary>
        /// Статическое свойство, которое возвращает количество созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount => _allRectanglesCount;

        /// <summary>
        /// Возвращает id прямоугольника.
        /// </summary>
        public int Id { get; private set; }
    }
}