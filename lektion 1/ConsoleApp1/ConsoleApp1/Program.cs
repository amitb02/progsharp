using System;
using System.Diagnostics.SymbolStore;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Skriv ut följande:
        /// "Hej" hörde jag någon säga på stan.
        /// Efter en stund svarade någon annan också med ett "Hej!".
        /// TIPS: Escape:a alla specialtecken som citationstecken med en bakslash \
        /// </summary>
        static void doWrite()
        {
            Console.WriteLine("""Hej"" hörde jag någon säga på stan.");
            Console.WriteLine("Efter en stund svarade någon annan också med ett \"Hej!\"");

        }
        static void Main(string[] args)
        {
            doWrite();
        }
    }
}
