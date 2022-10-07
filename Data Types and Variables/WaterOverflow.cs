using System;

namespace WaterOverflow
{
    internal class WaterOverflow
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {


                int l = int.Parse(Console.ReadLine());


                if (sum + l > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;

                }
                else
                {
                    sum += l;
                }


            }
            Console.WriteLine(sum);
        }


    }
}

