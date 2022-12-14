using System;

namespace PrintingTriangle
{
    internal class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintCols(i);
            }

            for (int i = num - 1; i >= 1; i--)
            {
                PrintCols(i);
            }
        }

        private static void PrintCols(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
