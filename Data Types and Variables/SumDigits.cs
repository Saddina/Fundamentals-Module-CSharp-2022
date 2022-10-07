using System;

namespace SumDigits
{
    internal class SumDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastDigit = 0;
            int nCopy = n;


            while (nCopy > 0)
            {
                lastDigit = nCopy % 10;
                nCopy /= 10;
                sum += lastDigit;
            }

            Console.WriteLine(sum);
        }
    }
}
