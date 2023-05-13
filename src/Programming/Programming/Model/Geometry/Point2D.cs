namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные координаты в 2д пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата x.
        /// </summary>
        private double _x;
        /// <summary>
        /// Координата y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Создает экземпляр класса Point2D.
        /// </summary>
        /// <param name="x">Координата x. Должна быть больше нуля.</param>
        /// <param name="y">Координата y. Должна быть больше нуля.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        /// <summary>
        /// Возвращает координату x.
        /// </summary>
        public double X
        {
            get => _x; 
            private set 
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            } 
        }
    
        /// <summary>
        /// Возвращает координату y.
        /// </summary>
        public double Y
        {
            get => _y; 
            private set 
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            } 
        }
    }
}