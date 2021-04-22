using System;

namespace Opg07_IfElse_7_8_ExpressLetter
{
    class ExpressLetterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PORTO BEREGNER PROGRAM");
            Console.WriteLine("Indtast vægten af brevet i gram:");
            string weightInput = Console.ReadLine();
            Console.WriteLine("Ekspres? (J):");
            string isExpressInput = Console.ReadLine();

            // Konverter input:
            int weight = Convert.ToInt32(weightInput);
            bool isExpress = false;     // Inden vi tester om brugeren ønskede ekspres, initialiseres variablen til FALSE. Så hvis IKKE brugeren har tastet J, er det stadig et almindeligt brev.
            if(isExpressInput == "J")
            {
                isExpress = true;   // Alternativt (og måske lidt kækt da læsbarheden af linjen mindskes): isExpress = !isExpress;
            }

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

            // Først her øges prisen hvis ekspres:
            if(isExpress)   // Bemærk at jeg ikke vælger syntaksen if(isExpress == true) da det ikke er nødvendigt. Mange elever tror det er nødvendigt.
            {
                price = price * 1.5m;   // Alternativt: price *= 1.5m; hvor *= er en compund assignment operator
            }

            Console.WriteLine($"Porto: {price:c2}");
        }
    }
}
