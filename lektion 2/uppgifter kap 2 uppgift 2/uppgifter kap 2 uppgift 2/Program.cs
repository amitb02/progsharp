using System;
using System.Dynamic;

namespace uppgifter_kap_2_uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tja, hur gammal är du?");
            string ålderText = Console.ReadLine();
            int ålder = int.Parse(ålderText);
            int ålderOmÅttaÅr = ålder + 8;
            Console.WriteLine("Om 8 år är du " + ålderOmÅttaÅr +" år gammal.");
            Console.WriteLine(" Hur stor snopp har du? " + "Svara i meter.");
            string kuklängd = Console.ReadLine();
            double penislängd = double.Parse(kuklängd);
            double ökadkuklängd = penislängd + 0.1;
            Console.WriteLine("Om ditt underliv var 10 cm längre skulle den varit average då?" + ökadkuklängd + "m.");
        }
    }
}
