using System;

namespace kap_2_uppgift_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ge mig min parra!");
            int parra = int.Parse(Console.ReadLine());
            int skuldKvar = 6000 - parra;
            Console.WriteLine("Yäni! du har " + skuldKvar + " floss att betala.");
        }
    }
}