using System;

namespace _1.Surface
{
    public class Circle : Shape
    {

        public Circle(double widht, double height)
            : base(widht, height)
        {
            if (widht != height)
            {
                throw new ArgumentException("not equals widht and height for circle");
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * Widht * Widht;
        }
    }
}
