using System;

namespace TopNumbers
{
    internal class TopNumbers
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            int currNum = 0;
            for (int i = 1; i <= end; i++)
            {
                currNum = i;
                bool isDivisible = IsDivisibleByEight(currNum);
                bool hasOdd = HasOddDigit(currNum);
                if (isDivisible && hasOdd)
                {
                    Console.WriteLine(currNum);
                }

            }


        }

        static bool IsDivisibleByEight(int currNum)
        {

            int remain = 0;
            int sum = 0;
            while (currNum > 0)
            {
                remain = currNum % 10;
                sum += remain;
                currNum = currNum / 10;
            }
            if (sum % 8 != 0)
            {
                return false;

            }
            return true;
        }

        static bool HasOddDigit(int currNum)
        {

            while (currNum > 0)
            {
                if ((currNum % 10) % 2 == 1)
                    return true;
                currNum /= 10;
            }
            return false;
        }
    }
}
