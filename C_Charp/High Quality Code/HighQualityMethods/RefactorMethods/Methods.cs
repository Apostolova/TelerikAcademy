namespace RefactorMethods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Invalid number!");
        }

        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Provider parameturs can't be null");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("No elements to provider!");
            }
            else
            {
                int maxElement = int.MinValue;
                for (int i = 0; i < elements.Length; i++)
                {
                    if (elements[i] > maxElement)
                    {
                        maxElement = elements[i];
                    }
                }

                return maxElement;
            }
        }

        public static void PrintNumberFormatFixedPoint(double number, string format)
        {
            Console.WriteLine("{0:" + format + "}", number);
        }

        public static void PrintNumberFormatPercent(double number)
        {
            Console.WriteLine("{0:p}", number);
        }

        public static void PrintNumberAligned(double number, string positionWidht)
        {
            Console.WriteLine("{0:" + positionWidht + "}", number);
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static bool IsHorizontal(double y1, double y2)
        {
            if (y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsVertical(double x1, double x2)
        {
            if (x1 == x2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintNumberFormatFixedPoint(1.3, "f");
            PrintNumberFormatPercent(0.75);
            PrintNumberAligned(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            bool horizontal = IsHorizontal(-1, 2.5);
            bool vertical = IsVertical(3, 3);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.PersonalInfo = new Student.PersonalInformation("17.03.1992", "Sofia");

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.PersonalInfo = new Student.PersonalInformation("03.11.1993", "Vidin", "gamer");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
