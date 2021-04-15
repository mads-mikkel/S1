using System;

namespace Opg05_Arithmetic_2
{
    class CalculatorProgram2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lommeregner v2");

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast første tal:");
            string firstNumberInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberInput);

            // Indhent første tal fra brugeren og konverter:
            Console.WriteLine("Indtast andet tal:");
            string secoondNumberInput = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secoondNumberInput);

            // Foretag de aritmetiske operationer, og gem i variable:
            int additionResult = firstNumber + secondNumber;
            int subtractionResult = firstNumber - secondNumber;
            int multiplicationResult = firstNumber * secondNumber;

            /* *** LÆRER NOTER: Divisionen giver ofte udfordringer for eleverne. Lad os i det følgende antage at første tal er 3 og andet tal er 2:
             *      int divisionResult = firstNumber / secondNumber;        vil give 1 og ikke det forventede 1,5. Samme resultat fås for
             *      double divisionResult = firstNumber / secondNumber;     Dette sker fordi firstNumber og secondNumber begge er af typen int. 
             *      Når disse så divideres med hinanden, beholdes kun heltals-delen efter divisionen.
             *      Så når resultatet af den matematiske division af 3/2 jo giver 1,5, giver C# i stedet for blot 1.
             *      Løsningen er at sørge for, at mindst én af operanderne er en double. Dette kan gøres ved et (double) cast umiddelbart foran én af operanderne, i stedet for bruge Convert.ToDouble på opranden:*/
            double divisionResult = (double)firstNumber / secondNumber;

            /* *** LÆRER NOTER: Ikke alle elever ved at man ikke kan dividere med 0, så det er oplagt at se hvad der sker når secondNumber er 0 (DivideByZeroException). */

            // Udskriv resultatet:
            Console.WriteLine($"{firstNumber} + {secondNumber} = {additionResult}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtractionResult}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplicationResult}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {divisionResult}");
        }
    }
}