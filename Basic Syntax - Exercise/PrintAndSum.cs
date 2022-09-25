using System;

namespace Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = n; i <= m; i++)
            {
                sum += i;
                Console.Write(i + " ");

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
