using System;

namespace NQueensHeuristic
{
    class Program
    {
        static int[] columnPlacement;
        static int solutionsCount = 0;

        static void Main(string[] args)
        {
            int n = 8; 
            columnPlacement = new int[n];
            SolveNQueens(0, n);
            Console.WriteLine($"Total solutions found: {solutionsCount}");
        }

        static void SolveNQueens(int row, int n)
        {
            if (row == n)
            {
                solutionsCount++;
                DisplayBoard(n);
            }
            else
            {
                for (int col = 0; col < n; col++)
                {
                    if (IsValidPlacement(row, col))
                    {
                        columnPlacement[row] = col;
                        SolveNQueens(row + 1, n);
                    }
                }
            }
        }

        static bool IsValidPlacement(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (columnPlacement[i] == col || 
                    Math.Abs(columnPlacement[i] - col) == Math.Abs(i - row))
                {
                    return false;
                }
            }
            return true;
        }

        static void DisplayBoard(int n)
        {
            Console.WriteLine($"Solution {solutionsCount}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (columnPlacement[i] == j)
                        Console.Write("Q ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
