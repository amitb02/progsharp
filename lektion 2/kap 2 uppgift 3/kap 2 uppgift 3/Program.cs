using System;

namespace kap_2_uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur snabb är du i jämförelse med Abbdi?" + " svara is sekunder");
            string abbdisFart = Console.ReadLine();
            double babbeSnabbhet = double.Parse(abbdisFart);
            double skillnad = 4.20 - babbeSnabbhet;
            Console.WriteLine("Abbbbooooo län! normala babbesnabbheten är 4.20 sekunder. Det betyder är du antingen en svenne eller en äkta blatte " + skillnad +" ifrån att vara en svenne" );
        }
    }
}
