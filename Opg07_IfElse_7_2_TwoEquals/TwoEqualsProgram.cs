using System;

namespace Opg07_IfElse_7_2_TwoEquals
{
    class TwoEqualsProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ER DE ENS?");
            Console.WriteLine("Indtast det første tal:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Indtast det andet tal:");
            string secondNumberInput = Console.ReadLine();

            int firstNumber, secondNumber;
            firstNumber = Convert.ToInt32(firstNumberInput);
            secondNumber = Convert.ToInt32(secondNumberInput);

            if(firstNumber == secondNumber)
            {
                Console.WriteLine("De to tal er ens.");
            }
            else
            {
                Console.WriteLine("De to tal er ikke ens.");
            }
        }
    }
}