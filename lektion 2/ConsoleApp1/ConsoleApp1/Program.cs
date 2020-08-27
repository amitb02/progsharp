using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vad heter du?");
            string helaNamnet = Console.ReadLine();
            int indexFörMellanslag = helaNamnet.IndexOf(" ");
            string förnamn = helaNamnet.Substring(0, indexFörMellanslag);
            string efternamn = helaNamnet.Substring(indexFörMellanslag + 1);
            Console.WriteLine("Ditt förnamn är " + förnamn +"." );
            Console.WriteLine("Ditt efternamn är " + efternamn +".");

        }
    }
}
