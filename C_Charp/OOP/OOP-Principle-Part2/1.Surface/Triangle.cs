
namespace _1.Surface
{
   public class Triangle : Shape
    {
       public Triangle(double widht, double height) 
           : base(widht, height)
       {
           this.Widht = widht;
           this.Height = height;
       }

       public override double CalculateSurface()
       {
           return  (this.Height * this.Widht) / 2;
       }
    }
}
