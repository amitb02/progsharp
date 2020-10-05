using System;

namespace kap_4_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är du bög?");
            string svar = Console.ReadLine();
            while (svar!="kanske")
            {
                Console.WriteLine("Fel svara,svara igen");
                svar = Console.ReadLine();
            }
            Console.WriteLine("Bruh! Du vet inte, vilken bög");
        }
    }
}
