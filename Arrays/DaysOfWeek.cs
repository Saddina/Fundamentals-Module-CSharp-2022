using System;

namespace Arrays
{
    internal class DaysOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            Console.WriteLine(daysOfWeek[day - 1]);
        }
    }
}
