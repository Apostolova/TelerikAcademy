namespace _1.RotatedSize
{
    using System;
    using System.Linq;

    public class Program
    {
        public static FigureSize GetRotatedSize(FigureSize figure, double angleOfRotate)
        {
            double cosAngle = Math.Cos(angleOfRotate);
            double sinAngle = Math.Sin(angleOfRotate);
            double rotateWidth = (Math.Abs(cosAngle) * figure.Width) + (Math.Abs(sinAngle) * figure.Height);
            double rotateHeight = (Math.Abs(sinAngle) * figure.Width) + (Math.Abs(cosAngle) * figure.Height);
            return new FigureSize(rotateWidth, rotateHeight);
        }


        public static void Main()
        {
        }
    }
}  