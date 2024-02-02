using System;

class Program
{
    static void Main()
    {
        int r = 8;
        int c = 8;

        int[,] board = new int[r, c];

        Randomly_Place(board);

        Console.WriteLine("Initial board:\n");
        Chess(board);

        Move(board);

        Console.WriteLine("Final board: ");
        Chess(board);

        Console.ReadLine();
    }

    static void Randomly_Place(int[,] board)
    {
        Random random = new Random();

        int random_r, random_c;
        do
        {
            random_r = random.Next(board.GetLength(0));
            random_c = random.Next(board.GetLength(1));
        } while (board[random_r, random_c] == 1);

=        board[random_r, random_c] = 1;
    }

    static void Move(int[,] board)
    {
        int knight_r = -1, knight_c = -1;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 1)
                {
                    knight_r = i;
                    knight_c = j;
                    break;
                }
            }
            if (knight_r != -1)
                break;
        }

        board[knight_r, knight_c] = 0; 

=        Random random = new Random();
        int random_r, random_c;
        do
        {
            random_r = random.Next(board.GetLength(0));
            random_c = random.Next(board.GetLength(1));
        } while (board[random_r, random_c] == 1);

=        board[random_r, random_c] = 1;
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