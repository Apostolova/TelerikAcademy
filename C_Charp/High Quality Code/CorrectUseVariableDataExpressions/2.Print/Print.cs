namespace _2.Print
{
    using System;
    using System.Linq;

    public class StaticData
    {
        private double[] dataNumbers;

        public StaticData(double[] numbers)
        {
            this.Numbers = numbers;
        }

        public double[] Numbers
        {
            get
            {
                return this.dataNumbers;
            }

            set
            {
                if (this.dataNumbers.Length == 0)
                {
                    throw new ArgumentNullException("The array of numbers is empty!");
                }
                else
                {
                    this.dataNumbers = value;
                }
            }
        }

        public void PrintMaxValue()
        {
            Console.WriteLine("Max value from array of numbers is: {0} ", this.FindMaxNumber(this.dataNumbers));
        }

        public void PrintMinValue()
        {
            Console.WriteLine("Min value from array of numbers is: {0} ", this.FindMinNumber(this.dataNumbers));
        }

        public void PrintAverageSum()
        {
            Console.WriteLine("The average sum from array of numbers is: {0} ", this.FindAverageSum(this.dataNumbers));
        }

        public double FindMaxNumber(double[] numbers)
        {
            double max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public double FindMinNumber(double[] numbers)
        {
            double min = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public double FindAverageSum(double[] numbers)
        {
            double numbersSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersSum += numbers[i];
            }

            return numbersSum / (numbers.Length + 1);
        }
    }
}
