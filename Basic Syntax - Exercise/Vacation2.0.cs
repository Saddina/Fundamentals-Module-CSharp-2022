using System;

namespace Vacation2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerOne = 0;
            double total = 0;

            if (groupType == "Students")
            {
                switch (day)
                {
                    case "Friday": pricePerOne = 8.45; break;
                    case "Saturday": pricePerOne = 9.80; break;
                    case "Sunday": pricePerOne = 10.46; break;
                }

                if (people >= 30)
                {
                    total = pricePerOne * people - (pricePerOne * people * 0.15);
                }
                else
                {
                    total = pricePerOne * people;
                }
            }
            else if (groupType == "Business")
            {
                switch (day)
                {
                    case "Friday": pricePerOne = 10.90; break;
                    case "Saturday": pricePerOne = 15.60; break;
                    case "Sunday": pricePerOne = 16; break;
                }

                if (people >= 100)
                {
                    total = (pricePerOne * people) - (10 * pricePerOne);
                }
                else
                {
                    total = pricePerOne * people;
                }
            }
            else if (groupType == "Regular")
            {
                switch (day)
                {
                    case "Friday": pricePerOne = 15; break;
                    case "Saturday": pricePerOne = 20; break;
                    case "Sunday": pricePerOne = 22.50; break;
                }

                if (people >= 10 && people <= 20)
                {
                    total = pricePerOne * people - (pricePerOne * people * 0.05);

                }
                else
                {
                    total = pricePerOne * people;

                }
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
