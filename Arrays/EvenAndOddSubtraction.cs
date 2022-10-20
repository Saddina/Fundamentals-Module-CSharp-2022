using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    internal class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            int sumOdd = 0;
            int sumEven = 0;
            int diff = 0;
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (currNum % 2 == 0)
                {
                    sumEven += currNum;
                }
                else
                {
                    sumOdd += currNum;
                }
                diff = sumEven - sumOdd;

            }


            Console.WriteLine(diff);



        }
    }
}
