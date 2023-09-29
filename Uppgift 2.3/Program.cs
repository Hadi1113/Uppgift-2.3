using System;

namespace Uppgift2_3
{
    class Program
    {
        static void Main(string[]args)
        {
            
            int startavgift = 300;
            int kostnadPerKilometer = 1;
            int extraDagKostnad = 500;

            
            Console.Write("Hur många dagar vill du hyra bilen: ");
            int antalDagar = int.Parse(Console.ReadLine());

            Console.Write("Hur många kilometer ska du köra: ");
            int antalKilometer = int.Parse(Console.ReadLine());

           
            int totalHyra = startavgift + (antalDagar - 1) * extraDagKostnad + antalKilometer * kostnadPerKilometer;

            
            Console.WriteLine($"Den totala hyran blir: {totalHyra} kr");

            
            Console.ReadLine();
        }
    }
}