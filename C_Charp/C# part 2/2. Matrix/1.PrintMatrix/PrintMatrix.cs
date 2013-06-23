using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Print(int[,] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintA(int[,] matrix, int n, int counter)
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = counter++;
                }
            }
            Print(matrix, n);
        }
        static void PrintB(int[,] matrix, int n, int counter)
        {
            for (int col = 0; col < n; col++)
            {
                if ((col & 1) == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = counter++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = counter++;
                    }
                }
            }
            Print(matrix, n);
        }
        static void PrintC(int[,] matrix, int n, int counter)
        {
            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n - row; col++)
                {
                    matrix[row + col, col] = counter++;
                }
            }
            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    matrix[row, col + row] = counter++;
                }
            }
            Print(matrix, n);
        }



        static void Main()
        {
            Console.Write("Enter N valid interval [1..19]: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine();
            PrintA(matrix, n, 1);
            PrintB(matrix, n, 1);
            PrintC(matrix, n, 1);
        }
    }
}

