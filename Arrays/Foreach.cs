using System;

namespace Foreach
{
    internal class Foreach
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            names[0] = "Sadina";
            names[1] = "Sofia";
            names[2] = "Miglen";

            // dostupvane elementi na array
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string item in names)
            {
                Console.WriteLine(item);
                // razlikata s for e chhe v foreach nqma dostup do index
                //ne iskame da promenqme
                // iskame samo da minem po daden spisuk
            }

        }
    }
}
/* string[] names = new string[3];

            names[0] = "Sadina";

                for (int i = 1; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            names[0] = "Sofia";
           */