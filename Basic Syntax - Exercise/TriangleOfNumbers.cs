using System;

namespace TriangleofNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            if (n >= 1 && n <= 20)
            {

                for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write($"{row} ");
                    }
                    Console.WriteLine();

                }
            }
            else { return; }
        }
    }
}
