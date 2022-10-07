using System;
using System.Numerics;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger startingYield = int.Parse(Console.ReadLine());
            BigInteger dayCount = 0;
            BigInteger total = 0;
            BigInteger totalForOneDay = 0;

            BigInteger copy = startingYield;
            if (startingYield < 100)
            {
                Console.WriteLine(dayCount);
                Console.WriteLine(total);
            }
            else
            {
                while (copy >= 100)
                {

                    totalForOneDay = copy - 26;
                    copy -= 10;
                    total += totalForOneDay;
                    dayCount++;


                }
                total -= 26;
                Console.WriteLine(dayCount);
                Console.WriteLine(total);


            }

        }
    }
}
