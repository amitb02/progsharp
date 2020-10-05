using System;
using System.Collections.Specialized;
using System.Xml;
/// <summary>
/// 2.1
/// fråga vad hen heter, vad den vill jobba med och vad hens mål är
/// </summary>
namespace övningar_kap_2
    
{
    class Program
    {
        static void Main (string[]args)
        {
            string meddelande = "Tjeeeena";
            string namn = "din mamma";
            string yrke = "hemlös";

            Console.WriteLine(meddelande);
            Console.WriteLine("jag heter " + namn+", mitt yrke är hemlös "+ ".");
            meddelande = "sug";
            Console.WriteLine(meddelande);
        }
    }
}
