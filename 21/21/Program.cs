using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            string senasteVinnaren = "Ingen har vunnit";
            Console.WriteLine("Hej, hej, tjena! vÄlKoMmEn TiLl TjUgOeTtAn");

            string menyVal = "0";
            while (menyVal != "4")
            {
                Console.WriteLine("Välj mellan dessa alternativ");
                Console.WriteLine("1. Spela spelet");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Regler för spelet");
                Console.WriteLine("4. Avsluta spelet");
                menyVal = Console.ReadLine();

                Console.WriteLine( );
                switch (menyVal)
                {
                    case "1":
                        int datornPoäng = 0;
                        int spelarensPoäng = 0;
                        Console.WriteLine("Två kort dras nu per spelare");
                        datornPoäng += slump.Next(1, 11);
                        datornPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);

                        string kortVal = "";
                        while (kortVal != "n" && spelarensPoäng <=21)
                        {

                        }

                        break;
                }
            }
        }
    }
}
