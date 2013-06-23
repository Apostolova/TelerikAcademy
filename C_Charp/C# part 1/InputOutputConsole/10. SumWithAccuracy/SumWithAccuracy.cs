using System;

class SumWithAccuracy
{
    static void Main()
    {
        decimal sum = 1m;
        decimal newsum = 1m;
        decimal i=2m;
        decimal differences;
        do
        {
            newsum = sum;
            {
                if (i % 2 == 0)
                {
                    sum += ((decimal)1 / i);
                }
                else
                {
                    sum += ((decimal)-1 / i);
                }
                i++;
                differences = ((decimal)Math.Abs (sum - newsum ));
            }
        }
        while (differences >= 0.001m); 
        Console.WriteLine(sum);
    }
}
