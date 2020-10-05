using System;

namespace kap_3_uppgift_2
{
    class Program
    {
        /// <summary>
        /// skapa ett programm som frågar vem som vann fotboll-vm damer år 2015
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Tjeeeena, vet du vem som vann Fotboll-VM år 2015?");
            string svar = Console.ReadLine().ToLower();
            if (svar == "usa")
            {
                Console.WriteLine("Du hade rätt");
            }
            if (svar != "usa")

            {
                Console.WriteLine("du är dum i huvudet");
            }

        }
    }
}
    
    

