using System;

namespace kap_2_uppgift_10
{
    class Program
        ///skriv en tabell med formaterad strängar
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{"Namn",-20} {"inkomst(kr)",15} {"Ålder(år)", 10}");
            Console.WriteLine($"{"Anna petterson",-20} {"69420", 15} {"39", 10}");
            Console.WriteLine($"{"Abdi Muhammed",-20} {"27000", 15} {"25", 10}");
        }
    }
}
