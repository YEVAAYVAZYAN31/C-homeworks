using System;

class Program
{
    static void Main()
    {
        int r = 8;
        int c = 8;

        int[,] board = new int[r, c];

        Randomly_Place(board);

        Chess(board);

        Console.ReadLine();
    }

    static void Randomly_Place(int[,] board)
    {
        Random random = new Random();

        for (int i = 0; i < board.GetLength(0); i++)
        {
            int random_c = random.Next(board.GetLength(1));

            board[i, random_c] = 1;
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