namespace Programming.Model.Classes
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        public double X
        {
            get => _x; 
            private set 
            {
                Validator.AssertOnPositiveValue(value, "X");
                _x = value;
            } 
        }
    
        public double Y
        {
            get => _y; 
            private set 
            {
                Validator.AssertOnPositiveValue(value, "Y");
                _y = value;
            } 
        }
    }
}