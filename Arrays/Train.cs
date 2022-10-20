using System;

namespace Train
{
    internal class Train
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int total = 0;

            for (int i = 0; i < n; i++)
            {

                array[i] = int.Parse(Console.ReadLine());
                total += array[i];

            }
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(total);
        }
    }
}
