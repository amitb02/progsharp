using System;
using System.ComponentModel.Design;

namespace kap_3_uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad fick du för poäng på NP?");
            int poäng = int.Parse(Console.ReadLine());
           if(poäng<18)
            { Console.WriteLine("Lol,du fick F"); 
            }
           else if(poäng<27)
            { Console.WriteLine("helt ok, du fick E"); 
           }
           else if(poäng<35)
            { 
                Console.WriteLine("bruh, bara ett D? verkligen det du satsar på?"); 
            }
           
            else if(poäng<46)
            { Console.WriteLine("pretty good mannen C"); 
            }
           else if (poäng<55)
            { Console.WriteLine("vilken nolla!, att få B är som att komma andraplats"); 
         
           }
           else
            { Console.WriteLine("Du fick A, vilken satsare"); 
            }
        }

    }
}
