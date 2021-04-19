using System;

namespace Opg05_Arithmetic_4
{
    class CalculatorProgram4
    {
        static void Main(string[] args)
        {
            /* *** LÆRER NOTER: Modulo (%-opratoren) giver resten ved division. F.eks. 10 % 5 = 0, fordi 5 går op i 10. Men 11 % 5 = 1, fordi der er 1 fra det tætteste 5 går op i, nemlig 10, til 11.
             * Modulo har en række fordelagtige anvendelser. F.eks. findes om et tal x er lige ved testen x % 2 == 0. Altså spørger man her om der ingen rest er ved divisionen x / 2. Hvis der er en
             * rest, så er x ulige, hvis der ikke er en rest så er x lige. Kun tallet 2 kan anvendes til dette. Op samme måde kan man undersøge om et tal b går op i et tal a ved testen a % b == 0.
             * Men da operatoren == først bliver introduceret for eleven i en kommende opgave, bør eleven ikke introduceres for dette i denne opgave.*/

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
