using System;

namespace Opg07_IfElse_7_1_Discount
{
    class DiscountProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RABAT PROGRAMMET");
            Console.WriteLine("Indtast beløbet (kr. og øre)");

            // Hent input og konverter. Anvend decimal da den datatype er designet til penge:
            string priceInput = Console.ReadLine();
            decimal price = Convert.ToDecimal(priceInput);

            // Initialiser to variable, én til rabatbeløbet og én til rabatprocenten:
            decimal discount = default;
            decimal discountPercentage = 0.05m;

            // Brug større end operatoren
            if(price > 1000m)
            {
                discount = price * discountPercentage;
            }
            Console.WriteLine($"Din rabat er {discount:c2} på købet til {price:c2}.\nAt betale: {price - discount:c2}");
        }
    }
}