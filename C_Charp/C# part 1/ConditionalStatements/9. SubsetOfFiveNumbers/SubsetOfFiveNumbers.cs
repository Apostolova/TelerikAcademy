using System;

class SubsetOfFiveNumbers
{
    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = (int.Parse(Console.ReadLine()));
        }
        int [] a = new int[1] {0};
       
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i+ 1; j <numbers.Length ; j++)
            {
                if (numbers[i] + numbers[j]== 0)
            
                    Console.WriteLine("Sum O two elements {0}, {1}", numbers[i], numbers[j]);
                    else
                    {
                    for (int k = j+1; k <numbers.Length; k++)
                    {
                        if ((numbers[i] + numbers[j] + numbers[k]) == 0)
                            Console.WriteLine("Sum O three elements {0}, {1}, {2}", numbers[i], numbers[j], numbers[k]);
                        else
                        {
                           
                           for (int m = k+1; m <numbers.Length; m++)
                    {
                        if ((numbers[i] + numbers[j] + numbers[k] + numbers[m]) == 0)
                            Console.WriteLine("Sum O four elements {0}, {1}, {2}, {3}", numbers[i], numbers[j], numbers[k], numbers[m]);
                        else
                        {
                             
                           for (int n = m+1; n <numbers.Length; n++)
                    {
                        if ((numbers[i] + numbers[j] + numbers[k] + numbers[m] + numbers[n]) == 0)
                            Console.WriteLine("Sum O five elements {0}, {1}, {2}, {3}, {4}", numbers[i], numbers[j], numbers[k], numbers[m], numbers[n]);
                     //  else
                        {
                            //Console.WriteLine("nqma suma o");
                        }
                           }
                        }
                           }
                        }
                    }
                }
            }
        }
        }    
    }



