﻿using System;

namespace Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Total(product, quantity);
        }

        static void Total(string product, int quantity)
        {
            double price = 0.00;
            switch (product)
            {

                case "coffee": price = 1.50; break;
                case "water": price = 1.00; break;
                case "coke": price = 1.40; break;
                case "snacks": price = 2.00; break;
            }
            double total = price * quantity;
            Console.WriteLine(total.ToString("F2"));
        }
    }
}
