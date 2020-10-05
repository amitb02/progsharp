using System;

namespace kap_4_uppgift_17
{
    class Program
    {
        /// <summary>
        /// skapa ett program som skiver 10-30 sedan 200-180 sen 1000-1400
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 10; i < 31; i++)
            {
                Console.WriteLine(i);
            }
                Console.WriteLine();
                for(int i =200; i>=180; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            for(int i = 1000; i < 1401; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
