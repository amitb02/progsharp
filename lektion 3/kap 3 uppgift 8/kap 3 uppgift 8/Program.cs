using System;

namespace kap_3_uppgift_8
{
    class Program
    ///Skapa ett program där användaren får skriva in en valfri sträng. Programmet ska sedan berätta ifall strängen innehåller...
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bror, skriv en mening");
            string mening = Console.ReadLine();
            if (mening.Contains("+") && mening.Contains("-"))
            {
                Console.WriteLine("walla, du tror du är mattematiker");
            }
            else if (mening.Contains("+"))
            {
                Console.WriteLine("walla, vem har med plus i en mening");
            }
            else if (mening.Contains("-"))
            {
                Console.WriteLine("vem fan har ett minustecken i sin mening");
            }
            else
            {
                Console.WriteLine("Cool mening..... not");
            }
        }

    }

}
