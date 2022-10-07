using System;

namespace Elevator
{
    internal class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;

            if (people % capacity == 0)
            {
                courses = people / capacity;
                Console.WriteLine(courses);
            }
            else
            {
                courses = (int)Math.Ceiling((double)people / capacity);
                Console.WriteLine(courses);

            }

            /* int ostatuk = 0;
             int restPeople = 0;
             if (people <= capacity)
             {

                 Console.WriteLine("All the persons fit inside in " +
                     "the elevator. Only one course is needed.");
             }

             else if (people % capacity == 0)
             {
                 courses = people / capacity;
                 Console.WriteLine($"{courses} courses * {capacity} people");

             }
             else if (people % capacity != 0)
             {
                 courses = (people / capacity);
                 ostatuk = (people % capacity);
                 restPeople = people - (courses * capacity);
                 Console.WriteLine($"{courses} courses * {capacity} people");
                 Console.WriteLine($"+ {ostatuk} courses * {restPeople} people");

             }*/






        }
    }
}
