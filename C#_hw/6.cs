using System;

class Program
{
    static void Main()
    {
        int r = 3;
        int c = 4;

        int[,] m = Randomly(r, c);
        Matrix(m);

        Console.ReadLine();
    }

    static int[,] Randomly(int rows, int cols)
    {
        int[,] m = new int[rows, cols];
        Random random = new Random();

        int total = rows * cols;

        var available = new System.Collections.Generic.List<int>(total);

        for (int i = 1; i <= total; i++)
        {
            available.Add(i);
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int random_index = random.Next(available.Count);

                matrix[i, j] = available[random_index];

                available.RemoveAt(random_index);
            }
        }

        return m;
    }

    static void Matrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}