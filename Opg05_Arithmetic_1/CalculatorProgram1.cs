using System;

namespace Opg05_Arithmetic_1
{
    class CalculatorProgram1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lommeregner v1");

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast første tal:");
            string firstNumberInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberInput);

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast andet tal:");
            string secoondNumberInput = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secoondNumberInput);

            // Foretag den aritmetiske operation, og gem i en variabel:
            int result = firstNumber + secondNumber;

            // Udskriv resultatet:
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");    
        }
    }
}