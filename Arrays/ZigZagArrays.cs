using System;
using System.Linq;

namespace ZigZagArrays
{
    internal class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int firstNum = nums[0];
                int secondNum = nums[1];

                if (i % 2 != 0)
                {
                    firstArray[i - 1] = firstNum;
                    secondArray[i - 1] = secondNum;


                }
                else
                {
                    firstArray[i - 1] = secondNum;
                    secondArray[i - 1] = firstNum;
                }
            }
            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}
