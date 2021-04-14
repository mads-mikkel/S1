using System;

namespace Opg03_Console
{
    class ConsoleProgram
    {
        static void Main(string[] args)
        {
            // *** LÆRER NOTER: Ud over at lære om selve Console, så lærer eleven også om begrebet sekvens: at instruktioner udføres i den rækkefølge de står i, oppefra og nedefter.

            // 3.1 Console baggrund
            Console.BackgroundColor = ConsoleColor.Green;

            
            // 3.2 Console skrifttype
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            
            // 3.3 Console vinduesstørrelse
            Console.WindowHeight = 10;
            Console.WindowWidth = 10;

            // *** LÆRER NOTER: Fra og med Visual Studio 2019 version 16.9, kommer der grønne linjer under de to ovenstående linjer. Dette sker fordi afviklingsplatformen er .NET 5.0 (target framework) og det betyder at dette program kan afvikles på både Windows, Linux og Mac. Men det ved programmet ikke, med mindre man laver en særlig attribut på Main metoden - men det er helt uden for scope på S1. Samme grønne linje er også i de følgende Console.Beep.

            
            // 3.4 Spil en sang
            // *** LÆRER NOTER: her er et eksempel på den klassiske DSB melodi med tonerne D - Es - B. D har frekvensen 587 Hz, Es = 622 Hz, B = 494 Hz.
            Console.Beep(587, 1000);    // Afspilles i 1 sekund
            Console.Beep(622, 500);     // Afspilles i ½ sekund
            Console.Beep(494, 500);     // Afspilles i ½ sekund
        }
    }
}