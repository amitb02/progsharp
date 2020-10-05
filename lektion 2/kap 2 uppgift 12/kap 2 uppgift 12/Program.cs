using System;

namespace kap_2_uppgift_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alma och Elin hoppade längdhopp, vem hopade längst?");
            string hopplängd = Console.ReadLine();
            int plusindex = hopplängd.IndexOf("+");
            String ElinText = hopplängd.Substring(0, plusindex);
            string AlmaText = hopplängd.Substring(plusindex + 1);
            double ElinLängd = double.Parse(ElinText);
            double AlmaLängd = double.Parse(AlmaText);
            double skillnad = ElinLängd - AlmaLängd;
            Console.WriteLine($"Detta är {skillnad} mellan vad Elin och Alma hoppade");


        }
    }
}
