using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                nums[i] = currNum;
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write($"{nums[i]} ");
            }

            /* for(int i = numbers.Length - 1; i >= 0; i--){
             * int currNum = int.Pars(Console.ReadLine());
             * numbers[i] = currNum;
             * }
             * Console.WriteLine(string.Join(' ', numbers));
             * */

            /* 
            for (int i = 0; i < nums.Length; i++)
            {
               nums[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < nums.Length / 2; i++){

                 var temp = nums[i];
                 nums[i] = nums[nums.Length - 1 - i];
                 nums[nums.Length - 1 - i] = temp; 
           }
            */
        }
    }
}

