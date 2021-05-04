using System;

namespace Opg11_While_2
{
    class WhileProgram
    {
        static void Main(string[] args)
        {
            int result = 0;

            int count = 0;
            while(count < 5)
            {
                Console.WriteLine("Indtast et tal: ");
                int number = Convert.ToInt32(Console.ReadLine());
                result = result + number;
                count++;
            }

            Console.WriteLine($"Summen af alle tallene er: {result}");

        }
    }
}
