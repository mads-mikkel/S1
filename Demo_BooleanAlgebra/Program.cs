using System;

namespace Demo_BooleanAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hh";
            int i = -7;

            if(s == "hh" ^ i > 0)
            {
                Console.WriteLine("g");
            }

            if(i < 0)
            {
                Console.WriteLine("j");
            }
            else
            {
                Console.WriteLine("l");
            }

        }
    }
}
