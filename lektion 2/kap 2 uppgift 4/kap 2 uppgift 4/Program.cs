using System;

namespace kap_2_uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Babbe, hur mycket sprit vill du ha?");
            int sprit = int.Parse(Console.ReadLine());
            Console.WriteLine("Babbe, berätta hur mycket knark du vill ha?");
            int knark = int.Parse(Console.ReadLine());
            int summa = sprit + knark;
            int produkt = sprit * knark;
            Console.WriteLine("summan av talen är:" + summa + ". Produkten av talet är" + produkt + ".");
        }
    }
}
