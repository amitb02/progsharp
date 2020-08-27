﻿using System;
using System.Diagnostics.SymbolStore;

namespace ConsoleApp1
{
    class Mugg
    {
        int vol = 0;
        public Mugg()
        {
        }
        
        public void fillMeUp(int fill)
        {
            if(fill < 0 || fill>100)
            {
                Console.WriteLine("Wrong value. Use a value between 0 and 100");
                return;
            }

            vol = fill;
            Console.Write("filling up\n");
        }
        private bool isEmpty()
        {
            return vol==0;
        }
        public void Write()
        {
            if (isEmpty())
            {
                Console.Write("empty\n");
            }
            else
            {
                Console.Write("full\n");
            }
        }
    }
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
            Console.WriteLine("\"Hej\" hörde jag någon säga på stan.");
            Console.WriteLine("Efter en stund svarade någon annan också med ett \"Hej!\"");

            Console.WriteLine("MUGG TEST:");
            Mugg amitsMugg = new Mugg();
            Mugg piotrsMugg = new Mugg();
            amitsMugg.Write();
            amitsMugg.fillMeUp(100);
            amitsMugg.Write();
            Console.WriteLine("PIOTR TEST:");
            piotrsMugg.Write();
        }
        static void Main(string[] args)
        {
            doWrite();
        }
    }
}
