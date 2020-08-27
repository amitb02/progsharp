using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening som består av två ord");
            string helaNamnet = Console.ReadLine();
            int indexFörMellanslag = helaNamnet.IndexOf(" ");
            string förnamn = helaNamnet.Substring(0, indexFörMellanslag);
            string efternamn = helaNamnet.Substring(indexFörMellanslag + 1);
            Console.WriteLine(efternamn + " " + förnamn);
        }
    }
}
