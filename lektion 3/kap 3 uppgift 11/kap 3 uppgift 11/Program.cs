using System;

namespace kap_3_uppgift_11
{
    /// <summary>
    /// fråga en person hur många datorer den har 
    /// sedan ska programmet upprepa siffran och skriva om hen har en dator eller flera datorer
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många datorer har du?");
            int antalDatorer = int.Parse(Console.ReadLine());
            string böjning = antalDatorer == 1 ? "dator" : "datorer";
            Console.WriteLine($"Du har {antalDatorer} {böjning}.");

        }
    }
}