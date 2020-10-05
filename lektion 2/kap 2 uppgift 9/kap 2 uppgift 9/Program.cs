using System;

namespace kap_2_uppgift_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du i Förnamn?");
            String Förnamn = Console.ReadLine();
            Console.WriteLine("Vad heter du i Efterman?");
            string Efternamn = Console.ReadLine();
            Console.WriteLine($"Lol, tänk dig att heta {Förnamn} {Efternamn}.");

        }
    }
}