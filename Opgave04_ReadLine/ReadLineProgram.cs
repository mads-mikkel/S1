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
            /* *** LÆRER NOTER: I opgaven står der følgende kodelinje:
                    int age = int.Parse( Console.ReadLine() ); 
                Didaktisk kan det være fordelagtigt at introducere eleven for Convert klassen i stedet for Parse metoder, samt at træne variable ved at gemme inputtet som en streng,
                inden konversionen foretages: */
            Console.WriteLine("OPG. 4.3 Indlæs et tal fra konsollen");
            Console.WriteLine("Skriv et helt tal:");
            string integerNumberInput = Console.ReadLine();    // Gem altid input i en variabel.
            int number = Convert.ToInt32(integerNumberInput);  // Brug Convert klassen og ikke Parse, da det semantisk er mere læseligt. ToInt32 betyder bare int (alias type).
            Console.WriteLine(number);                  // Vi behøver ikke at gen-konvertere til en string, da WriteLine kan modtage hvad-som-helst og udskrive det. Så vi sender bare number variablen ind i WriteLine metoden, og så sørger den for resten. Jeg oplever jævnligt elever der gemmer i en string variabel inden udskrivning, hvilket er unødvendigt.
            // *** LÆRER NOTE: Når man indtaster noget andet end et tal, får man en exception - altså en program undtagelse, bedre kendt som et crash.
            // Kommatal:
            Console.WriteLine("Skriv et kommatal:");
            string decimalNumberInput = Console.ReadLine();
            double decimalNumber = Convert.ToDouble(decimalNumberInput);
            Console.WriteLine(decimalNumber);
            /* *** LÆRER NOTE: På dansk anvender vi komma som decimaltalsseparator, men det på engelsk anvendes punktum. 
             * Anvender man punktum som decimaltalsseparator i input (f.eks. 2.56), konverteres input til double værdien 256. 
             * Anvendes komma, får man som forventet 2,56. */

            // 4.4 Ekstra opgave: arealudregning
            /* *** LÆRER NOTE: Dette er en ekstraopgave fordi der skal anvendes en aritmetisk operator * (multiplikation), men det er først i Opgave 05 at eleven skal introduceres til det. Denne opgave er derfor til de elever der er særligt videnbegærlige.*/
            Console.WriteLine("Længde (m):");
            string lengthInput = Console.ReadLine();
            double length = Convert.ToDouble(lengthInput);  // Brugeren bliver spurgt efter længden i meter, som jo kan være et decimaltal, derfor konverteres input til double.
            Console.WriteLine("Bredde (m):");
            string widthInput = Console.ReadLine();
            double width = Convert.ToDouble(widthInput);
            double area = length * width;   // Resultatet af multiplikationen skal også gemmes i en double, da to decimaltal ganget sammen også vil give et decimaltal.
            Console.WriteLine($"Areal: {area} m²");     // to tallet er unicode karakter U+00B2. Kopieret ind i VS fra et andet program eller browser, da det ikke kan genskabes via tastaturet.

            // 4.5 Ekstra opgave: Console.WriteLine()
            /* *** LÆRER NOTE: Denne opgave er mest for at få tiden til gå, hvis der er stor forskel på eleverns arbejdstempo. 
             Opgaven kan enten løses ved at lave 6 Console.WriteLine eller mere udfordrende, ved at lave én string variabel og så outputte den i en Console.WriteLine.*/
        }
    }
}