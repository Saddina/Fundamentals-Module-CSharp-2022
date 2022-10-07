using System;

namespace BeerKegs
{
    internal class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestV = 0.0;
            double maxR = 0.0;
            int maxH = 0;
            string biggestM = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double v = Math.Pow(r, 2) * h * Math.PI;

                if (v > biggestV)
                {
                    biggestV = v;
                    maxR = r;
                    maxH = h;
                    biggestM = model;

                }

            }
            Console.WriteLine(biggestM);

        }
    }
}
