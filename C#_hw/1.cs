using System;

class Program
{
    static void Main()
    {
        int r = 8;
        int c = 8;

        int[,] board = new int[r, c];

        int knight_r = 3; 
        int knight_c = 4; 

        board[knight_r, knight_c] = 1;

        Chess(board);

        Console.ReadLine();
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