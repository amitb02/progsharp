using System;

namespace kap_3_uppgift_7
{
    class Program
    ///Skapa ett program där användaren får skriva in tre olika ord på var sin rad. Programmet ska berätta om det första ordet kommer först i bokstavsordning av alla de tre orden.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tjenna, wallahi skriv tre ord");
            string ord1 = Console.ReadLine();
            string ord2 = Console.ReadLine();
            string ord3 = Console.ReadLine();
            if (ord1.CompareTo(ord2) <0 && ord1.CompareTo(ord3)<0)
            {
                Console.WriteLine("din analfabetiska mupp, visste du att ord 1 kommer först i alfabetet?");
            }
            else

            {
                Console.WriteLine("din analfabetiska mupp,visste du att ord 2 kommer först i alfabetet?");
            }
        }
    }
}
