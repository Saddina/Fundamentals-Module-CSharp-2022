using System;

namespace PrintPartOfASCIITable
{
    internal class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                char currCh = (char)i;
                Console.Write(currCh + " ");
            }
        }
    }
}
