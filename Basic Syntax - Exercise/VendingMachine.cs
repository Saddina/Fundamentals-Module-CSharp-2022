using System;

namespace Vending__Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            double price = 0;
            double moneySum = 0;

            while (command != "Start")
            {

                if (double.Parse(command) != 0.1 && double.Parse(command) != 0.2 && double.Parse(command) != 0.5 && double.Parse(command) != 1
                    && double.Parse(command) != 2)
                {
                    Console.WriteLine($"Cannot accept {command}");

                }
                else
                {
                    moneySum += double.Parse(command);
                }
                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {

                switch (product)
                {
                    case "Nuts": price = 2; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1; break;
                    default: Console.WriteLine("Invalid product"); break;

                }

                if (price <= moneySum && price > 0 && moneySum > 0)
                {

                    moneySum = moneySum - price;
                    price = 0;
                    Console.WriteLine($"Purchased {product}");

                }
                else if (price > 0)
                {

                    price = 0;
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();

            }
            Console.WriteLine($"Change: {moneySum:f2}");



        }

    }
}

