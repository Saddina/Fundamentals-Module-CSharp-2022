using System;
using System.Linq;

namespace LadyBugs
{
    internal class LadyBugs
    {
        static void Main(string[] args)
        {

            //Initialize empty field
            int n = int.Parse(Console.ReadLine());

            int[] field = new int[n];
            int[] initialIndexes = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            //Spawn ladybugs on the valid indexes
            //This collection remains unchanged
            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    //Valid index => laadybug on this index(1)
                    field[index] = 1;
                }
            }

            // Proceed game moves (Start game)
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(cmdArguments[0]);
                string direction = cmdArguments[1];
                int flyLength = int.Parse(cmdArguments[2]);

                // Validate ladybugIndex is inside the field!
                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    continue;
                }

                // Validate ladybugIndex contains ladybug
                if (field[ladybugIndex] == 0)
                {
                    continue;
                }
                // Try to proceed move
                // right ==> ladybugIndex + flyLength
                // Left ==> ladybugIndex - flyLength
                //First -> Our ladyBug starts flying => it removes from the field, it is in the air
                field[ladybugIndex] = 0;
                if (direction == "left")
                {
                    flyLength *= -1; // 1 == -1
                }
                // 0 right 1 ==> 0+1 =1
                //1 left 1 ==> 1 +(-1) = 0
                int nextIndex = ladybugIndex + flyLength;
                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength;
                }

                //There are two posibilities
                // variant a) nextIndex is calculated somewhere in the field
                //variant b) nextIndex cannot be calculated in the field
                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    //variant b
                    continue;
                }
                //Variant a 
                //Land ladybug on the valid index
                field[nextIndex] = 1;
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
