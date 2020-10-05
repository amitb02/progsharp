using System;

namespace kap_3_uppgift_12
    ///skapa ett program som frågar någon hur gammal hen är, sedan svarar om hen får vara med i en tävling

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du mannen?");
            int ålder = int.Parse(Console.ReadLine());
            bool tillåtelse = ålder > 16 && ålder < 19 ? true : false;
            if (tillåtelse == true)
            {
                Console.WriteLine("Du får vara med i tävlingen");
            }
            else
            {
                if (ålder > 19)
                {
                    Console.WriteLine("Du är för gammal, dra till en bar eller något");
                }
                else
                {
                    Console.WriteLine("Du är för ung för att vara med i tävlingen, dra och köp godis eller något");
                }
            }
        }
    }
}
