using System;

namespace Opg07_IfElse_7_4_LargestNumber
{
    class LargestNumberProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HØJESTE TAL PROGRAM");
            Console.WriteLine("Indtast det første tal:");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Indtast det andet tal:");
            string secondNumberInput = Console.ReadLine();

            int firstNumber, secondNumber;
            firstNumber = Convert.ToInt32(firstNumberInput);
            secondNumber = Convert.ToInt32(secondNumberInput);

            if(firstNumber > secondNumber)
            {
                Console.WriteLine($"Det største tal er {firstNumber}.");
            }
            else if(firstNumber == secondNumber)
            {
                Console.WriteLine("Tallene er lige store.");
            }
            else
            {
                // *** LÆRE NOTE: Bemærk at vi først ser om det første er større end det andet. Dernæst tester vi for lighed mellem de to tal. Den eneste mulghed der er tilbage, er at det andet tal må være det størete. Altså kan man anvende udelukkelsesmetodik ved if-else kontrolstrukturen.
                Console.WriteLine($"Det største tal er {secondNumber}.");
            }
        }
    }
}