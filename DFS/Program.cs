using System;

namespace DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[4, 4]
            {
                { 1, 1, 0, 0 },
                { 0, 1, 1, 0 },
                { 0, 0, 1, 0 },
                { 1, 0, 0, 0 }
            };

            int size = GetLargestConnection(grid);
            Console.WriteLine(size);
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        static int GetLargestConnection(int[,] matrix)
        {
            int largeConnection = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    if (matrix[row, column] == 1) {
                        int size = GetConnectionSize(matrix, row, column);
                        largeConnection = Math.Max(largeConnection, size);
                    }
                }
            }

            return largeConnection;
        }

        static int GetConnectionSize(int[,] matrix, int row, int column)
        {            
            // Corner Cases
            if (row < 0 || column < 0 || row >= 4|| column >= 4)
            {
                return 0;
            }

            if (matrix[row, column] == 0)
            {
                return 0;
            }

            // Mark as visited
            matrix[row, column] = 0;
            int size = 1;

            PrintMatrix(matrix);

            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = column - 1; c <= column + 1; c++)
                {
                    if (r != row || c != column)
                    {
                        size += GetConnectionSize(matrix, r, c);
                    }
                }
            }

            return size;
        }
    }
}
