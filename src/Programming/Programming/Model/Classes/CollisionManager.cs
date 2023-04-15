using System;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double width1 = rectangle1.Width;
            double width2 = rectangle2.Width;

            double length1 = rectangle1.Length;
            double length2 = rectangle2.Length;
            
            double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            
            if (dX < width1 + width2 && dY < length1 + length2)
            {
                return true;
            }
            
            return false;
        }
        
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double radius1 = ring1.OuterRadius; 
            double radius2 = ring2.OuterRadius; 
            
            double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            double c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            if (c < radius1 + radius2)
            {
                return true;
            }
            
            return false;
        }
    }
}