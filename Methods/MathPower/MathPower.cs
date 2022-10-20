using System;

namespace MathPower
{
    internal class MathPower
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            double result = MathPow(num, pow);
            Console.WriteLine(result);

        }

        static double MathPow(double num, int pow)
        {
            double res = 1.00;
            for (int i = 1; i <= pow; i++)
            {
                res *= num;
            }
            return res;
        }
    }
}
