using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;
        
        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius;
        
        /// <summary>
        /// Создает экземпляр класса Ring.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должен быть больше внутреннего и быть позитивным числом.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть меньше внешнего и быть позитивным числом.</param>
        /// <param name="center"></param>
        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
        
        /// <summary>
        /// Возвращает и задает координаты кольца.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен быть больше внутреннего и быть позитивным числом.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (value < _innerRadius)
                {
                    throw new System.AggregateException("OuterRadius не может быть меньше InnerRadius");
                }
                else
                {
                    _outerRadius = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен быть меньше внешнего и быть позитивным числом.
        /// </summary>
        /// <exception cref="AggregateException"></exception>
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (value > _outerRadius)
                {
                    throw new System.AggregateException("InnerRadius не может быть больше OuterRadius");
                }
                else
                {
                    _innerRadius = value;
                }
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get => (Math.PI * Math.Pow(_outerRadius, 2)) - (Math.PI * Math.Pow(_innerRadius, 2));
        }
    }
}