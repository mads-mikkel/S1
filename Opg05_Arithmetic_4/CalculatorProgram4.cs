using System;

namespace Opg05_Arithmetic_4
{
    class CalculatorProgram4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lommeregner v4");

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast første tal:");
            string firstNumberInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstNumberInput);

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast andet tal:");
            string secondNumberInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondNumberInput);

            // Foretag de aritmetiske operationer, og gem i variable:
            double additionResult = firstNumber + secondNumber;
            double subtractionResult = firstNumber - secondNumber;
            double multiplicationResult = firstNumber * secondNumber;
            double divisionResult = (double)firstNumber / secondNumber;
            double moduloResult = firstNumber % secondNumber;

            // Udskriv resultatet:
            Console.WriteLine($"{firstNumber} + {secondNumber} = {additionResult}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtractionResult}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplicationResult}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {divisionResult}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {moduloResult}");
        }
    }
}
