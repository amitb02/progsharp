using System;
using System.Threading;

namespace lektion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");
            Thread.Sleep(5000);
            Console.WriteLine("Detta är ett program gjort i C#");
            Console.WriteLine("Programmet skriver ut text på flera rader.");
            Console.WriteLine("Detta är programmets sista utskrift");
            Console.WriteLine("Här är lite text");
            Console.WriteLine("nytt test på programmet");
            // här är en kommentar till texten ovanför
            /* Skall testa detta 
            */
            Console.WriteLine("Denna text kommer fram" +
                "denna text kommer på samma rad" +
                "körs");
            Console.WriteLine(" Om du skriver cw sen shiftar två gånger skriver du console.writlines");
            // om du vill ha kommatcken ska du skriva som man gör under/*
            Console.WriteLine("här skrivs ett \"-tecken ut.");
            Console.WriteLine("ett bakstreck \\ syns här.");
            Console.WriteLine("här blir det \n en ny rad och \t\t två tab.");







        }
    }
}
