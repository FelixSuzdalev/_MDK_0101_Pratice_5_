using System;

namespace Task_6
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Введите размерность массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] nul = new int[n];
            Random rand = new Random();
            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < n; ++i)
            {
                a[i] = (int)rand.Next(0, 3);
                Console.Write(" " + a[i]);
            }
            Console.WriteLine("\nЭлементы = 0 находится на позициях: ");
            for (int i = 0; i < n; ++i)
            {
                if (a[i] == 0)
                {
                    nul[i] = i + 1;

                    Console.Write($" {nul[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}
