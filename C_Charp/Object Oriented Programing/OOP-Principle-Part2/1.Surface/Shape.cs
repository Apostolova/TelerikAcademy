using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Surface
{
    public abstract class Shape
    {
        private double widht;
        private double height;

        public Shape(double widht, double height)
        {
            this.Widht = widht;
            this.Height = height;
        }

        public double Widht
        {
            get
            {
                return this.widht;
            }
            set
            {
                if (widht < 0)
                {
                    throw new ArgumentOutOfRangeException("You don't have negative widht");
                }
                else
                {
                    this.widht = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (height < 0)
                {
                    throw new ArgumentOutOfRangeException("You don't have negative height");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public abstract double CalculateSurface();
        
    }
}
