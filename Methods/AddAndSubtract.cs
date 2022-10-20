using System;

namespace AddAndSubtract
{
    internal class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = GetSumOf1and2(first, second);
            int result = GetResult(sum, third);

            Console.WriteLine(result);

        }

        static int GetSumOf1and2(int first, int second)
        {
            int sumOf1and2 = first + second;
            return sumOf1and2;
        }

        static int GetResult(int sum, int third)
        {
            return sum - third;
        }
    }
}
