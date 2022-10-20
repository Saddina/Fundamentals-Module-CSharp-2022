using System;

namespace Sign_OfIntegerNumbers
{
    internal class SignOfIntegerNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NumSign(n);
        }
        static void NumSign(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }

        }


    }
}
