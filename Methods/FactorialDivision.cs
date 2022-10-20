using System;

namespace FactorialDivision
{
    internal class FactorialDivision
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            GetFactorialN1(n1);
            GetFactorialN2(n2);



            double res = Result(n1, n2);
            Console.WriteLine("{0:F2}", res);

        }

        static double GetFactorialN1(double n1)
        {
            double n1Fact = 1;
            if (n1 >= 1)
            {

                for (double i = n1; i >= 1; i--)
                {
                    n1Fact *= i;
                }
            }
            return n1Fact;
        }

        static double GetFactorialN2(double n2)
        {
            double n2Fact = 1;
            if (n2 >= 1)
            {

                for (double i = n2; i >= 1; i--)
                {
                    n2Fact *= i;
                }
            }
            return n2Fact;
        }

        static double Result(double n1, double n2)
        {

            double res = GetFactorialN1(n1) / GetFactorialN2(n2);
            return res;
        }

    }
}
