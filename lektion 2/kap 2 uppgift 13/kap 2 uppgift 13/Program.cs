using System;

namespace kap_2_uppgift_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Walla på yalla! Välkommen till BabbeAbs biluthyrning, hur länge ska ni lånish bilen?");
            string lånishText= Console.ReadLine();
            int lånish = int.Parse(lånishText);

            Console.WriteLine("Hur många km kommer du köra bror?");
            string kmText = Console.ReadLine();
            int km = int.Parse(kmText);

            int kostnad = 300 + km + 500 * (lånish - 1);
            Console.WriteLine($"wallahi, det kostar {kostnad}kr,jalla jip.");
        }
    }
}
