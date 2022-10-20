using System;

namespace Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (cmd == "add")
            {
                Add(a, b);
            }
            else if (cmd == "multiply")
            {
                Multiply(a, b);
            }
            else if (cmd == "subtract")
            {
                Subtract(a, b);
            }
            else if (cmd == "divide")
            {
                Divide(a, b);
            }

        }

        private static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        private static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        private static void Add(int a, int b)
        {

            Console.WriteLine(a + b);

        }
    }
}
