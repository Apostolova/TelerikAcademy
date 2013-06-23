namespace RefactorLoops
{
    using System;
    using System.Linq;

   public class RefactorLoop
    {
       public static void Main(string[] args)
        {
            int expectedValue = int.Parse(Console.ReadLine());
            int[] numbers = Inicialization();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            SearchingValue(numbers, expectedValue);
        }

       public static int[] Inicialization()
        {
            Console.WriteLine("Enter count of elements: ");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];
            for (int count = 0; count < elements; count++)
            {
                array[count] = int.Parse(Console.ReadLine());
            }

            return array;
        }

       public static void SearchingValue(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == searchValue)
                    {
                        Console.WriteLine("Value Found");
                    }
                }
            }
        }
    }
}
