using System;

namespace Multiplication_Table2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nn = int.Parse(Console.ReadLine());

            if(nn > 10)
            {
                Console.WriteLine($"{n} X {nn} = {n * nn}");
            }
            else
            {
                for (int i = nn; i <= 10; i++)
                {

                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            
            
        }
    }
}
