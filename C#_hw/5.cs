using System;

class Program
{
    static void Main()
    {
        int[,] m = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Find_Point(m);

        Console.ReadLine();
    }

    static void Find_Point(int[,] m)
    {
        int r = m.GetLength(0);
        int c = m.GetLength(1);

        for (int i = 0; i < r; i++)
        {
            int max_r = m[i, 0];
            int c_index = 0;

            for (int j = 1; j < c; j++)
            {
                if (m[i, j] > max_r)
                {
                    max_r = matrix[i, j];
                    c_index = j;
                }
            }

            bool Saddle_Point = true;

            for (int k = 0; k < r; k++)
            {
                if (m[k, c_index] < max_r)
                {
                    Saddle_Point = false;
                    break;
                }
            }

=            if (Saddle_Point)
            {
                Console.WriteLine($"Saddle Point: {max_r} at position ({i + 1}, {c_index + 1})");
                return;
            }
        }

        Console.WriteLine("No saddle point found.");
    }
}