using System;

namespace Opg05_Arithmetic_3
{
    class CalculatorProgram3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lommeregner v3");

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast første tal:");
            string firstNumberInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberInput);

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast andet tal:");
            string secondNumberInput = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberInput);

            // Foretag de aritmetiske operationer, og gem i variable:
            int additionResult = firstNumber + secondNumber;
            int subtractionResult = firstNumber - secondNumber;
            int multiplicationResult = firstNumber * secondNumber;
            double divisionResult = (double)firstNumber / secondNumber;
            int moduloResult = firstNumber % secondNumber;

            // Udskriv resultatet:
            Console.WriteLine($"{firstNumber} + {secondNumber} = {additionResult}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtractionResult}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplicationResult}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {divisionResult}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {moduloResult}");
        }
    }
}
