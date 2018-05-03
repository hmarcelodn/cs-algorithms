using System;
using System.Drawing;

namespace MazeSolver
{
    class Program
    {
        static char[,] maze = new char[4, 4]
        {
                { '#', '.', '.', '.' },
                { '.', '.', '#', '.' },
                { 'S', '#', '#', '.' },
                { '#', '#', '#', 'F' }
        };

        static int[,] map = new int[4, 4]
        {
                { 0,0,0,0 },
                { 0,0,0,0 },
                { 0,0,0,0 },
                { 0,0,0,0 },
        };

        static Point startingPoint = new Point();

        static void Main(string[] args)
        {
            Console.WriteLine("Rat in Maze Solver! \n");

            FindStartingPoint();
            if (SolveMaze(startingPoint.X, startingPoint.Y))
            {                
                Print();
            }
            else {
                Console.Clear();
                Console.WriteLine("There is no solutions for this maze.");
            }

            Console.WriteLine("Solution...");
            Console.ReadKey();
        }

        static void FindStartingPoint() {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (IsStart(i, j)) {
                        startingPoint.X = i;
                        startingPoint.Y = j;
                    }
                }
            }
        }

        static void Print() {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(map[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Press to continue...");
            Console.ReadKey();
        }

        static bool SolveMaze(int x, int y) {
            // Base Cases
            if (x < 0 || x >= 4) { return false; }
            if (y < 0 || y >= 4) { return false; }
            if (IsEnd(x, y)) {
                map[x, y] = 0;
                return true;
            }
            if (IsWall(x, y)) { return false; }
            if (map[x, y] == 1) { return false; }

            Print();
            // Mark Solution
            map[x, y] = 1;

            // Recursion
            if (SolveMaze(x - 1, y)) { return true; }
            if (SolveMaze(x + 1, y)) { return true; }
            if (SolveMaze(x, y + 1)) { return true; }
            if (SolveMaze(x, y - 1)) { return true; }

            // Unmark Solution
            map[x, y] = 0;

            return false;
        }

        static bool IsEnd(int x, int y) {
            return maze[x, y] == 'F';
        }

        static bool IsStart(int x, int y) {
            return maze[x, y] == 'S';
        }

        static bool IsWall(int x, int y) {
            return maze[x, y] == '#';
        }
    }
}
