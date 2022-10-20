using System;
using System.Linq;

namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                   .Split(" ")
                   .Select(int.Parse)
                   .ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] copyArray = new int[nums.Length];
            copyArray = nums;

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < copyArray.Length; j++)
                {

                    if (nums[i] + copyArray[j] == n)
                    {

                        int element1 = nums[i];
                        int element2 = copyArray[j];
                        Console.WriteLine($"{element1} {element2}");

                    }
                }
            }
        }
    }
}
