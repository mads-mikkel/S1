using System;

namespace Opg07_IfElse_7_6_PositiveNegative
{
    class PosotiveNegativeProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POSITIVT NEGATIVT PROGRAM");
            Console.WriteLine("Indtast et tal:");
            string numberInput = Console.ReadLine();

            int number = Convert.ToInt32(numberInput);

            string output = String.Empty;   // Her anvender jeg en variabel, som jeg bagefter tildeler en værdi i if-else kontrolstrukturen. Først når dette er sket, udskriver jeg variablen.
            if(number > 0)
            {
                output = $"{number} er positivt";
            }
            else if(number < 0)
            {
                output = $"{number} er negativt";
            }
            else    // Igen anvendes udelukkelsesmetoden:
            {
                output = "Tallet er 0";
            }

            Console.WriteLine(output);
        }
    }
}