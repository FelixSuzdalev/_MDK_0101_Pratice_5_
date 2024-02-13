using System;

namespace Task_16
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество строк в массиве: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[,] mn = new int[m, n];
            int x = rand.Next(2, 5),k = rand.Next(2,5);
            Console.WriteLine($"Рандомные значения: x = {x}, k = {k}\n");

            Console.WriteLine($"Массив размерностью m = {m} на n = {n}\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mn[i, j] = rand.Next(1, 10);
                    Console.Write($"  {mn[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mn[i, j] == x)
                    {
                        mn[i, j] *= k;
                    }
                }
            }

            Console.WriteLine("\nИзмененный массив:\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"  {mn[i, j].ToString().PadLeft(4)}");
                }
                Console.WriteLine();
            }
        }
    }
}
