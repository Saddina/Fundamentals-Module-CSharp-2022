using System;

namespace Strong_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numCopy = n;
            int factorialSum = 0;

            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int factorial = 1; // starts from 1 because it stores a product
                for (int i = 2; i <= lastDigit; i++) // skip 1 because 1*1=1
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }
            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
