using System;

namespace testuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 7, summa = 0, x = 0;
            while (summa<1000)

            {
                summa += z;
                x++;
                z += 7;
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
