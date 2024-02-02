using System;
class Program
{
    static void Main()
    {
        int r = 8;
        int c = 8;

        int[,] board = new int[r, c];
        int queen_r = 3; 
        int queen_c = 4; 
        board[queen_r, queen_c] = 1;
        Queen_Moves(board, queen_r, queen_c);
        Chess(board);
        Console.ReadLine();
    }

    static void Queen_Moves(int[,] board, int row, int col)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
           board[i, col] = 1; 
            board[row, i] = 1; 
        }
        for (int i = 1; i < board.GetLength(0); i++)
        {
            if (row + i < board.GetLength(0) && col + i < board.GetLength(1))
                board[row + i, col + i] = 1;

            if (row - i >= 0 && col + i < board.GetLength(1))
                board[row - i, col + i] = 1;

            if (row + i < board.GetLength(0) && col - i >= 0)
                board[row + i, col - i] = 1;

            if (row - i >= 0 && col - i >= 0)
                board[row - i, col - i] = 1;
        }
    }

    static void Chess(int[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}