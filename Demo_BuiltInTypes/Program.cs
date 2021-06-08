using System;
using System.Threading;

namespace Demo_BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string input = "";

            while(!done)
            {
                Console.Write("Indtast din fødseldag: ");
                input = Console.ReadLine();
                bool isCorrect = DateTime.TryParse(input, out DateTime date);
                if(isCorrect)
                {
                    string output = "";
                    int age = 2021 - date.Year;
                    if(age >= 16)
                    {
                        output += "Kan købe øl\n";
                    }
                    if(age >= 17)
                    {
                        output += "Kan køre bil\n";
                    }
                    if(age >= 18)
                    {
                        output += "Kan købe spiritus\n";
                    }
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine("Prøv igen");
                }
            }
        }
    }
}