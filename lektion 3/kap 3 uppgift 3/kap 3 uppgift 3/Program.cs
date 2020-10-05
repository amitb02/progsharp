using System;

namespace kap_3_uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Kompis! Vad gillar du att käka på matkortet?");
            string mat = Console.ReadLine().ToLower();
            if (mat == "berliner")
            {


                Console.WriteLine("gott!");
                
            }


            else if (mat == "liba")
            {
              
                Console.WriteLine("Jättegott!");
                
            }

            else
            { Console.WriteLine("äckligt!"); 
            }





        }
       

     }
        
    
    
}

