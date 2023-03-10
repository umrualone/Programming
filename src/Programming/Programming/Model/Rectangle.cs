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

    public Rectangle()
    {
        Length = 1;
        Width = 1;
        Color = null;
    }

    public double Length
    {
        get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Длина должна быть больше нуля");
                }

                _length = value;
            }
    }

    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
            {
                throw new System.ArgumentException("Ширина должна быть больше нуля");
            }

            _width = value;
        }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
}