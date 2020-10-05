using System;

namespace kap_3_uppgift_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Walla bror, hur lång är du? Ghabba svara i meter!");
            double längd = double.Parse(Console.ReadLine());
            if (längd >= 1.5 && längd < 1.9)
            {

                Console.WriteLine("Wallahi,Du får åka bror");
            }

            else
            {
                Console.WriteLine("Lol, du får inte åka. Vilken tönt");

            }

        }
    }
}
