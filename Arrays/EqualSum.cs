using System;
using System.Linq;

namespace EqualSum
{
    internal class EqualSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
            bool isFound = false;

            for (int i = 0; i < nums.Length; i++)
            {
                int sumLeft = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += nums[j];
                }
                int sumRight = 0;
                for (int r = nums.Length - 1; r > i; r--)
                {
                    sumRight += nums[r];
                }

                if (sumLeft == sumRight)
                {
                    isFound = true;
                    Console.WriteLine(i);
                }

            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
