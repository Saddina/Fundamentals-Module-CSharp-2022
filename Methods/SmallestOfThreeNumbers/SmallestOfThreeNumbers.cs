using System;

namespace SmallestOfThreeNumbers
{
    internal class SmallestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int smallest = GetSmallest(first, second, third);
            Console.WriteLine(smallest);
        }

        static int GetSmallest(int first, int second, int third)
        {
            int smallest;

            if (first < second && first < third)
            {
                smallest = first;
            }
            else if (second < first && second < third)
            {
                smallest = second;
            }
            else
            {
                smallest = third;
            }

            return smallest;
        }
    }
}
