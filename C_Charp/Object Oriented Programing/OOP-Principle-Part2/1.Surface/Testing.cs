using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Surface
{
    class Testing
    {
        static void Main()
        {
            Shape[] Figure = new Shape[]
            {
                new Triangle(15, 2),
                new Rectangle(10, 3),
                new Circle(4, 4),
            };
            foreach (Shape figure in Figure)
            {
                Console.WriteLine(figure.GetType());
                Console.WriteLine(figure.CalculateSurface());
            }
           

        }
    }
}
