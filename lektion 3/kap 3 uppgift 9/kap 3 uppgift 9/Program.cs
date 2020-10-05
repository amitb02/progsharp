using System;

namespace kap_3_uppgift_9
{
    class Program
    {
        /// <summary>
        /// Skapa ett program som frågar användaren vilken plats hen kom på i den senaste idrottsturneringen hen var med på
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken plats kom du i tuneringen bror?");
            string plats = Console.ReadLine();
            switch (plats)
            {
                case "1":
                    Console.WriteLine("första plast walla, guld medalj");
                    break;
                case "2":
                    Console.WriteLine("andra plats, du får sliver medalj");
                    break;
                case "3":
                    Console.WriteLine("tredje plats huh, du får bara brons");
                    break;
                default:
                    Console.WriteLine("skit dålig, du får ingen medalj");
                    break;
            }

        }
    }
}
