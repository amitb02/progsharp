using System;

namespace kap_3_uppgift_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tjeeeena, hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
          
            if (ålder>=65 ||(ålder>=10 && ålder <=18))
            {
                Console.WriteLine("walla du får kafferea");
            }

            else
            {
                Console.WriteLine("Walla, du får ingen rea");
            }

        }
    }
}
