using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BestMatrix
{
    class BestMatrix
    {
        public static int BestSum(int [,] matrix)
        {
            int bestRow = 0;
            int bestCol = 0;
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            return bestSum;
        }

        static void Main(string[] args)
        {
            
            StreamReader reader = new StreamReader(@"..\..\Matrix.txt");
            StreamWriter writer = new StreamWriter(@"..\..\Result.txt");
            using (reader)
            {
                int N = int.Parse(reader.ReadLine());
                int[,] matrix = new int[N, N];
                for (int i = 0; i < N; i++)
                {
                   
                    string row = reader.ReadLine();
                    string[] matrixOfStrings = row.Split(' ');
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = int.Parse(matrixOfStrings[j]);
                        Console.WriteLine("martix[{0},{1}]={2}", i, j, matrix[i,j]);
                    }
                }
                int result = BestSum(matrix);
                using (writer)
                {
                    writer.WriteLine(result);
                }
            }
        }
    }
}
