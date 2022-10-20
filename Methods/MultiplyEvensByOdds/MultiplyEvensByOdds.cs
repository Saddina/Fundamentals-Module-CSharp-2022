using System;

namespace MultiplyEvensByOdds
{
    internal class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));

            int sumOfEven = GetSumEven(absValue.ToString());
            int sumOfOdd = GetSumOdd(absValue.ToString());

            int result = sumOfEven * sumOfOdd;
            Console.WriteLine(result);
        }

        private static int GetSumOdd(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNum = Math.Abs(int.Parse(input[i].ToString()));
                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }

        private static int GetSumEven(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currNum = (int.Parse(input[i].ToString()));
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }
    }
}
