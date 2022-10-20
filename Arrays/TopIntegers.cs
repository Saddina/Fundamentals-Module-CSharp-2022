using System;
using System.Linq;

namespace TopIntegers
{
    internal class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int currNum = nums[i];

                bool isTopInteger = true;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    int nextNum = nums[j];
                    if (nextNum >= currNum)
                    {
                        isTopInteger = false; break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
