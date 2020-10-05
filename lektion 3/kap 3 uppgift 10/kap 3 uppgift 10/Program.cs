using System;
using System.Security.Cryptography;

namespace kap_3_uppgift_10
{
    class Program
        
        /// gör en frågesport med tre kategorier

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tjeeena, välj en kategiro\n1.Musik \n2.Geografi \n3 Historia \nSkriv 1, 2, eller 3");
            string kategori = Console.ReadLine();
            Console.Clear();

            switch (kategori)
            {
                case ("1"):
                Console.WriteLine("Vilket band gjorde låten Another brick in the wall?");
                    string svar1 = Console.ReadLine().ToLower();
                    if (svar1 == "Pink floyed")
                {
                 Console.WriteLine("rätt svar bror");
                }
                else
                {
                        Console.WriteLine("Du hade fel svar.....");
                }
                    break;
                case ("2"):
                    Console.WriteLine("Vad heter tysklands huvudstad?");
                    string svar2 = Console.ReadLine().ToLower();
                    if (svar2 == "berlin")
                    {
                        Console.WriteLine("rätt svar mannen");
                    }
                    else if (svar2 == "Berlin")
                    {
                        Console.WriteLine("rätt svar mannen");
                    }
                    else
                    {
                        Console.WriteLine("bruh, du är dum");
                    }
                    break;
                case ("3"):
                    Console.WriteLine("Vad heter Obama i efternman?");
                    string svar3 = Console.ReadLine().ToLower();
                    if (svar3 == "Obama")
                    {
                        Console.WriteLine("grttis,du är inte dum i huvudet");
                    }
                    else
                    {
                        Console.WriteLine("Bruh, är du seriös?");
                    }
                    break;
                default:
                    Console.WriteLine("Ge mig en kategori,1 , 2, eller 3");
                    break;
            }

        }
    }
}
