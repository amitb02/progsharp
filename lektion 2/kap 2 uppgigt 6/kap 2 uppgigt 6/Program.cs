using System;

namespace kap_2_uppgigt_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Säg ett tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ge mig ett till tal");
            double tal2 = double.Parse(Console.ReadLine());
            double summa = tal1 + tal2;
            double medel = summa / 2;
            Console.WriteLine("Ditt medelvärde är " + medel +".");
        }



    }
}
