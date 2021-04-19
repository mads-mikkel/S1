using System;

namespace Opg6B_Comparison_2_Huskøb
{
    class ComparisonOperatorsProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vekommen til Huskøb programmet.");
            
            Console.WriteLine("Indtast din månedsløn i hele kr.:");
            string monthlySalaryInput = Console.ReadLine();
            int monthlySalary = Convert.ToInt32(monthlySalaryInput);
            int yearlySalary = monthlySalary * 12;
            Console.WriteLine($"Din årsløn er {yearlySalary} kr.");

            Console.WriteLine("Indtast husprisen i hele kr.:");
            string housePriceInput = Console.ReadLine();
            int housePrice = Convert.ToInt32(housePriceInput);
            double housePriceThreshold = housePrice * 0.2;

            bool canBuyHouse = yearlySalary > housePriceThreshold;
            Console.WriteLine($"Du kan købe huset: {canBuyHouse}");

        }
    }
}