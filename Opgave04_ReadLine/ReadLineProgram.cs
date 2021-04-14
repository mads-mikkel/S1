using System;

namespace Opgave04_ReadLine
{
    class ReadLineProgram
    {
        static void Main(string[] args)
        {
            // *** LÆRER NOTER: I disse opgaver lærer eleven det helt centrale i al software, nemlig Input, Processering, Output, samt får øvet sekvens forståelsen.

            // 4.1 Første brugerinput:
            Console.WriteLine("Skriv noget:");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            // 4.2 Brugerens fornavn og efternavn
            // *** LÆRER NOTER: Her skal eleven forstå at input fra tastaturet skal gemmes i en variabel, inden det kan bruges til noget. Eleven skal også i denne opgave begynde at forstå UX (User eXperience, brugeroplevelse) ved at informere brugeren om hvad brugeren skal gøre for at anvende programmet, og dette sker ved flittig anvendelse af Console.WriteLines.
            Console.WriteLine();    // Tom linje for at adskille denne opgave fra den ovenstående.
            Console.WriteLine("--- OPG. 4.2 Brugerens fornavn og efternavn. ---");
            Console.WriteLine("Indtast dit fornavn:");
            string firstnameInput = Console.ReadLine();
            Console.WriteLine("Indtast dit efternavn:");
            string lastnameInput = Console.ReadLine();
            string output = $"Velkommen {firstnameInput} {lastnameInput}!";
            Console.WriteLine(output);

            // 4.3 Indlæs et tal fra konsollen
            // *** LÆRER NOTER: I opgaven står der følgende kodelinje:
            //     int age = int.Parse( Console.ReadLine() ); 
            // Didaktisk kan det være fordelagtigt at introducere eleven for Convert klassen i stedet for Parse metoder, samt at træne variable ved at gemme inputtet som en streng, inden konversionen foretages:
            Console.WriteLine("OPG. 4.3 Indlæs et tal fra konsollen");
            Console.WriteLine("Skriv et tal:");
            string numberInput = Console.ReadLine();    // Gem altid input i en variabel.
            int number = Convert.ToInt32(numberInput);  // Brug Convert klassen og ikke Parse, da det semantisk er mere læseligt. ToInt32 betyder bare int.
            Console.WriteLine(number);                  // Vi behøver ikke at gen-konvertere til en string, da WriteLine kan modtage hvad-som-helst og udskrive det. Så vi sender bare number variablen ind i WriteLine metoden, og så sørger den for resten.
            // *** LÆRER NOTE: Når man indtaster noget andet end et tal, får man en exception - altså en program undtagelse, bedre kendt som et crash

        }
    }
}