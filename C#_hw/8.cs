using System;

namespace KnightsTourHeuristic
{
    class Program
    {
        static int[] moveX = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] moveY = { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int[,] board;
        static int n;
        static int movesCount = 0;

        static void Main(string[] args)
        {
            n = 8; 
            board = new int[n, n];
            int startX = 0; 
            int startY = 0; 
            SolveKnightsTour(startX, startY);
            Console.WriteLine("No solution found.");
        }

        static void SolveKnightsTour(int x, int y)
        {
            board[x, y] = ++movesCount;

            if (movesCount == n * n)
            {
                PrintBoard();
                Environment.Exit(0); 
            }

            for (int i = 0; i < 8; i++)
            {
                int newX = x + moveX[i];
                int newY = y + moveY[i];

                if (IsValidMove(newX, newY) && board[newX, newY] == 0)
                {
                    SolveKnightsTour(newX, newY);
                }
            }

            board[x, y] = 0;
            movesCount--;
        }

        static bool IsValidMove(int x, int y)
        {
            return x >= 0 && x < n && y >= 0 && y < n;
        }

        static void PrintBoard()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{board[i, j],-3}");
                }
                Console.WriteLine();
            }
        }
    }
}
