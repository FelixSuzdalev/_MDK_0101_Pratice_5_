using System;

namespace Task_6_3
{
    internal class Program
    {
        static void Main()
        {
            //const int n = 8;
            Console.WriteLine("Введите размерность квадратной матрицы:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    a[i, j] = j + 1 + i;
                    Console.Write($" {a[i, j]} ");
                }
                for (int k = n - i; k < n; k++)
                {
                    a[i, k] = 0;
                    Console.Write($" {a[i, k]} ");
                }
                Console.WriteLine();
            }
        }
    }
}