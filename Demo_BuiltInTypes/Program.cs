using System;
using System.Threading;

namespace Demo_BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast din fødseldag: ");
            string input = Console.ReadLine();
            DateTime birthDate = Convert.ToDateTime(input);
            TimeSpan daysOld = DateTime.Today - birthDate;
            Console.WriteLine($"Du er {daysOld.Days} dage gammel.");
        }
    }
}

            



//DateTime dt = null; //default;