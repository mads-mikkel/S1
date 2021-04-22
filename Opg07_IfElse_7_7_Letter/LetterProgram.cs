using System;

namespace Opg07_IfElse_7_7_Letter
{
    class LetterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PORTO BEREGNER PROGRAM");
            Console.WriteLine("Indtast vægten af brevet i gram:");
            string weightInput = Console.ReadLine();

            int weight = Convert.ToInt32(weightInput);

            decimal price = default;    // Her anvender jeg en variabel, som jeg bagefter tildeler en værdi i if-else kontrolstrukturen. Først når dette er sket, udskriver jeg variablen.
            if(weight < 20)
            {
                price = 5m;
            }
            else if(weight < 50)
            {
                price = 7m;
            }
            else if(weight < 100)
            {
                price = 10m;
            }
            else if(weight < 150)
            {
                price = 15m;
            }
            else if(weight < 200)
            {
                price = 20m;
            }
            else
            {
                price = 30m;
            }

            Console.WriteLine($"Porto: {price:c2}");
        }
    }
}