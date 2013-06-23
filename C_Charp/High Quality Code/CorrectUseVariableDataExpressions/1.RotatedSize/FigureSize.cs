namespace _1.RotatedSize
{
     using System;
     using System.Linq;

    public class FigureSize
    {
        private double width;
        private double height;

        public FigureSize(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (this.height < 0)
                {
                    throw new ArgumentNullException("Height must be positive.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (this.width < 0)
                {
                    throw new ArgumentNullException("Width must be positive.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
    }
}
