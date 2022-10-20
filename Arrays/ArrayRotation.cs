using System;
using System.Linq;

namespace ArrayRotation
{
    internal class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int timesToRotate = rotations % nums.Length; // не забавя програмата при подаване на много гобям брой ротаци,които трябва да бъдат извършени
            for (int r = 1; r <= timesToRotate; r++)
            {
                int firstEl = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i - 1] = nums[i];
                }
                nums[nums.Length - 1] = firstEl;

            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
