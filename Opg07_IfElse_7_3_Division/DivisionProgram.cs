using System;

namespace Opg07_IfElse_7_3_Division
{
    class DivisionProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIVISIONSPROGRAM");
            Console.WriteLine("Indtast det første tal:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Indtast det andet tal:");
            string secondNumberInput = Console.ReadLine();

            int firstNumber, secondNumber;
            firstNumber = Convert.ToInt32(firstNumberInput);
            secondNumber = Convert.ToInt32(secondNumberInput);
            
            if(secondNumber == 0)
            {
                Console.WriteLine("Kan ikke dividere med 0");
            }
            else
            {
                Console.WriteLine($"{firstNumber}/{secondNumber} = {firstNumber/secondNumber}");
            }
        }
    }
}