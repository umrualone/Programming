public class Rectangle
{
    private double length;
    private double width;
    private string color;

    public Rectangle(double length, double width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
    }

    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = null;
    }

    public double Length
    {
        get { return length; }
        set
        {
            if (value <= 0)
            {
                throw new System.ArgumentException("Длина должна быть больше нуля");
            }

            length = value;
        }
    }

    public double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new System.ArgumentException("Ширина должна быть больше нуля");
            }

            width = value;
        }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
}