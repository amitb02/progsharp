using System;

namespace kap_2_uppgift_7
{
    class Program
        /// Uppgiften går ut på att skriva två seperata ord med ett mellanslag
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kan du skriva två ord?");
            string ord = Console.ReadLine();
            int indexFörMellanslag = ord.IndexOf(" ");
            string ordA = ord.Substring(0, indexFörMellanslag);
            string ordB = ord.Substring(indexFörMellanslag + 1);
            Console.WriteLine("Nu ska jag anväda häxkraft för att byta plats på orden: " + ordB + "" + ordA);

        }
    }
}
