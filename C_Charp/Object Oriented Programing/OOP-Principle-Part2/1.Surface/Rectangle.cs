
namespace _1.Surface
{
   public class Rectangle : Shape
    {
       public Rectangle(double widht, double height)
           : base(widht, height)
       {
           this.Widht = widht;
           this.Height = height;
       }

       public override double CalculateSurface()
       {
           return Widht * Height;
       }
    }
}
