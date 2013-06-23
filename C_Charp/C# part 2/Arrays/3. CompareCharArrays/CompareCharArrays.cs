using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter size of array 1");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter size of array 2");
        int M = int.Parse(Console.ReadLine());
        char[] array1 = new char[N];
        char[] array2 = new char[M];
        Console.WriteLine("Enter elements of array 1");
        for (int i = 0; i < N; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("Enter elements of array 2");
                array2[i] = char.Parse(Console.ReadLine());

                  if (array1[i] > array2[i])
                {
                    Console.WriteLine("Lexicographically The Second Array is First");
                    break;
                }
                else if (array1[i] < array2[i])
                {
                    Console.WriteLine("Lexicographically The First Array is First");
                    break;
                }
                else if (i>N)
                  {
                     Console.WriteLine("Lexicographically The Second Array is First");
                    break;
                {
                  
                    {
                    Console.WriteLine("Lexicographically The  Arrays are Equal");
                    }
                }
            }
        }
    }
}

       
    

