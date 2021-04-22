using System;

namespace Opg07_IfElse_7_5_AscendingOrder
{
    class AscendingOrderProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TO TAL I STIGENDE ORDEN PROGRAM");
            Console.WriteLine("Indtast det første tal:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Indtast det andet tal:");
            string secondNumberInput = Console.ReadLine();

            int firstNumber, secondNumber;
            firstNumber = Convert.ToInt32(firstNumberInput);
            secondNumber = Convert.ToInt32(secondNumberInput);

            string output = String.Empty;   // Her anvender jeg en variabel, som jeg bagefter tildeler en værdi i if-else kontrolstrukturen. Først når dette er sket, udskriver jeg variablen.
            if(firstNumber > secondNumber)
            {
                output = $"Orden: {secondNumber}, {firstNumber}";
            }
            else if(secondNumber > firstNumber)
            {
                output = $"Orden: {firstNumber}, {secondNumber}";
            }
            else
            {
                output = "Tallene er ens, og der kan ikke laves en orden.";
            }

            Console.WriteLine(output);
        }
    }
}