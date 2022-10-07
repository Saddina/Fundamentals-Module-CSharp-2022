using System;
using System.Numerics;

namespace IntegerOperations
{
    internal class IntegerOperations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            long firstResult = (long)a + b;
            long secondResult = firstResult / c;
            BigInteger finalResult = (BigInteger)secondResult * d;

            Console.WriteLine(finalResult);
        }
    }
}
