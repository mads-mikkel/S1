using System;

namespace Opg06A_Comparison
{
    class ComparisonOperatorsProgram
    {
        static void Main(string[] args)
        {
            /* *** LÆRER NOTER: Sammenligningsoperatorerne give altid en bool som resultat (dvs. en værdi der enten er TRUE eller FALSE. Man kan gemme et sådan resuktat i en varibel hvis
             * man ønsker det: bool result = a == b; I disse opgaver skal gives resultatet af sammenligningsoperationerne blot videre til WriteLine, uden at gemme i en variabel først.
             * Opgavens titel er simple udsagn, hvor udsagn er frit oversat fra det engelske 'statement' - frit oversat igen til 'program instruks'.
             * En typisk fejl jeg oplever er at en elev vil forsøge dette: Console.WriteLine( a = b), altså hvor eleven mangler ét = tegn. Et = tegn anvendes kun når vi skal tildele 
             * en værdi til en variabel. To = tegn, altså == er lighedssammenligningsoperatoren.
             * I Visual studio kan man sætte breakpoints med F), og så holde musen henover bpde variable og operatorer og så værdier og resultater af regnestykker og sammenligninger. Dette kan
             * være en ganske stor hjælp til eleverne i forståelsen af både syntaks og operatorerne. */

            // Opg 6.1 Simple udsagn
            int a = 2;
            int b = 4;

            // 1:
            Console.WriteLine(a == b);      // Er a lige med b? svar: FALSE

            // 2:
            Console.WriteLine(a > b);       // Er a større end b? svar: FALSE

            // 3:
            Console.WriteLine(a <= b);      // Er a mindre end eller lig med b? Svar: TRUE

            // 4: 
            Console.WriteLine(a - b > 0);   // Er resultatet af regnestykket a-b større end 0? Svar: FALSE, fordi a-b = 2-4 = -2.  

            // 5:
            Console.WriteLine(a + b > 0);   // Er resultatet af regnestykket a+b større end 0? Svar: TRUE, fordi a+b = 2+4 = 6.

            // 6:
            Console.WriteLine(a > 1 - b);   // Er a større end resultatet af regnestykket 1-b? Svar: FALSE, fordi 1-b = -3 og a=2.

            /* *** LÆRER NOTE: Der mangler flere opgaver til disse sammenligningsoperatorer. Men på tavlen kan man f.eks. udvide med flere variable, f.eks. c = -3 og 
             */

        }
    }
}