using System;

namespace Opg06B_Comparison_Alcohol
{
    class AlcoholProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ALKOHOL PROGRAMMET");

            Console.WriteLine("Indtast dit fødselsår:");
            string birthYearInput = Console.ReadLine();
            int birthYear = Convert.ToInt32(birthYearInput);

            int age = 2021 - birthYear;     // Her er antagelsen om at man allerede har haft fødselsdag i år.
            bool isOldEnoughForBeer = age >= 16;    
            bool isOldEnoughForSpirits = age >= 18;

            Console.WriteLine($"Du må købe øl: {isOldEnoughForBeer}");
            Console.WriteLine($"Du må spiritus: {isOldEnoughForSpirits}");
        }
    }
}