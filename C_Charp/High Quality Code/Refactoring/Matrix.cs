using System;

   public struct Coordinates
    {
        private int X { get; set; }

        private int Y { get; set; }
    }

    public class WalkInMatrix
    {
        private const int DirectionLenght = 8;

       public static void Inicializacion(ref int X, ref int Y)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            for (int count = 0; count < DirectionLenght; count++)
            {
                if (directionX[count] == X && directionY[count] == Y)
                {
                    currentDirection = count;
                    break;
                }
            }

            if (currentDirection == 7) 
            { 
                X = directionX[0];
                Y = directionY[0];
                return; 
            }

            X = directionX[currentDirection + 1];
            Y = directionY[currentDirection + 1];
        }

       public static bool CheckInicializacion(int[,] arr, int row, int colomn)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < DirectionLenght; i++)
            {
                if (row + directionX[i] >= arr.GetLength(0) || row + directionX[i] < 0)
                {
                    directionX[i] = 0;
                }

                if (colomn + directionY[i] >= arr.GetLength(0) || colomn + directionY[i] < 0)
                {
                    directionY[i] = 0;
                }
            }

            for (int i = 0; i < DirectionLenght; i++)
            {
                if (arr[row + directionX[i], colomn + directionY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

       public static void FindCell(int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        public static int ReadInput()
        {
            return 6;
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }
        }

        public static void PrintMatrixOnConsole(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                
                Console.WriteLine();
            }
        }

       public static void Main()
        {
            int n = ReadInput();
            int[,] matrix = new int[n, n];
            int k = 1, currentX = 0, currentY = 0, X = 1, Y = 1;

            DrowMatrix(n, matrix, ref k, ref currentX, ref currentY, ref X, ref Y);

            FindCell(matrix, out currentX, out currentY);

            if (currentX != 0 && currentY != 0)
            { 
                X = 1; 
                Y = 1;
                DrowMatrix(n, matrix, ref k, ref currentX, ref currentY, ref X, ref Y);
            }

            PrintMatrixOnConsole(matrix);
        }

        private static void DrowMatrix(int n, int[,] matrix, ref int k, ref int currentX, ref int currentY, ref int X, ref int Y)
        {
            while (true)
            {
                matrix[currentX, currentY] = k;
                if (!CheckInicializacion(matrix, currentX, currentY))
                {
                    break;
                }

                bool conditional = currentX + X >= n || currentX + X < 0 || currentY + Y >= n || currentY + Y < 0 || matrix[currentX + X, currentY + Y] != 0;
                if (conditional)
                {
                    while (currentX + X >= n || currentX + X < 0 || currentY + Y >= n || currentY + Y < 0 || matrix[currentX + X, currentY + Y] != 0)
                    {
                        Inicializacion(ref X, ref Y);
                    }
                }

                currentX += X;
                currentY += Y;
                k++;
            }
        }
}
