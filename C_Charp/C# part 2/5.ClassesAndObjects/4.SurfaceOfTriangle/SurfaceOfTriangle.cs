using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SurfaceOfTriangle
{
    class SurfaceOfTriangle
    {
        public static void SideAndAnAltitude()
        {
            Console.WriteLine("Side a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Altitude h");
            double h = double.Parse(Console.ReadLine());
            double Area = (a * h)/2;
            Console.WriteLine("Area from 'b' and 'h' is: {0}", Area);
        }

        public static void ThreeSides()
        {
            Console.WriteLine("Side a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Side b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Side c");
            double c = double.Parse(Console.ReadLine());
            double s = (a+b+c)/2;
            double Area = Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
            Console.WriteLine("Area from 3 sides 'a', 'b', 'c' is: {0}", Area);
        }

        public static void TwoSidesAndAngle()
        {
            Console.WriteLine("Side a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Side b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Angle");
            double angle = double.Parse(Console.ReadLine());
            double Area = (a * b * Math.Sin(Math.PI*angle/180))/2;
            Console.WriteLine("Area from 2 sides and angles between them is: {0}", Area);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("To calculate surface of triangle by side and an altitude to it: Enter 1");
             Console.WriteLine("To calculate surface of triangle by  three sides: Enter 2");
             Console.WriteLine("To calculate surface of triangle by  two sides and angle between them: Enter 3");
            int yourchoice = int.Parse(Console.ReadLine());
            switch (yourchoice)
            {
                case 1: SideAndAnAltitude();
                    break;
                case 2: ThreeSides();
                    break;
                case 3: TwoSidesAndAngle();
                    break;
                default: Console.WriteLine("incorrect choice");
                    break;
            }

        }
    }
}
