using System;

namespace Opg12_For_2
{
    class ForProgram
    {
        static void Main(string[] args)
        {
            // 1.

            for(int i = 0; i <= 30; i += 3)
            {
                if(i == 0)
                {
                    continue;   // Skipper resten og går videre til næste iteration
                }
                Console.WriteLine(i);
            }

            // 2
            for(int i = 0; i <= 70; i += 7)
            {
                if(i == 0)
                {
                    continue;   // Skipper resten og går videre til næste iteration
                }
                Console.WriteLine(i);
            }

            // 3

        }
    }
}
