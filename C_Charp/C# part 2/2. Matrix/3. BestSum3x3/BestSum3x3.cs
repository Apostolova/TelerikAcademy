using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BestSum3x3
{
    static void Main()
    {
        Console.WriteLine("Enter size of martix N =");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M =");
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M];
        for (int row = 0; row <N-1; row++)
            for (int col = 0; col < M-1; col++)
            {
                Console.WriteLine("matrix[{0}, {1}]=", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        int bestRow = 0;
		int bestCol = 0;
        //int[,] matrix = {
        //    {7, 1, 3, 3, 2, 9},
        //    {1, 3, 9, 8, 5, 6},
        //    {4, 6, 7, 9, 9, 0},
        //    {8, 10, 12, 1, 9, 3}
        //};
        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col+1] + matrix[row, col+2] + matrix[row+1, col] + matrix[row+1, col+1] + matrix[row+1, col+2] + matrix[row+2, col] + matrix[row+2, col+1] + matrix[row+2, col+2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
					bestCol = col;
                }
            }
        Console.WriteLine("  {0} {1} {2}", 
			matrix[bestRow, bestCol], 
			matrix[bestRow, bestCol+1],
            matrix[bestRow, bestCol+2]);
        Console.WriteLine("  {0} {1} {2}", 
			matrix[bestRow+1, bestCol], 
			matrix[bestRow+1, bestCol+1],
            matrix[bestRow+1, bestCol+2]);
        Console.WriteLine("  {0} {1} {2}", 
			matrix[bestRow+2, bestCol], 
			matrix[bestRow+2, bestCol+1],
            matrix[bestRow+2, bestCol+2]);
        Console.WriteLine("The max sum is: {0}", bestSum);

    }
}

