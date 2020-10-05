using System;

namespace kap_2_uppgift_8
{
    class Program
        ///skriva två tal som ska addears utan mellanslag
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tjenis penis,skriv två tal som ska addears med varandra");
            string tal = Console.ReadLine();
            int plusindex = tal.IndexOf("+");
            int talA = int.Parse(tal.Substring(0, plusindex));
            int talB = int.Parse(tal.Substring(plusindex + 1));
            int summa = talA + talB;
            Console.WriteLine("Här är svaret:"+ summa);
        }
    }
}
