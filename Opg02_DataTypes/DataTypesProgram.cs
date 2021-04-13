using System;

namespace Opg02_DataTypes
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            //---------- OPGAVE 2.1 ----------
            // Erklæring og initialisering af variable:
            string firstName = "Karsten";
            string lastName = "Hansen";
            string age = "35";

            // *** LÆRER NOTE: Man kan udskrive på mange forskellige måder.
            // 1. Tre Console.WriteLine, med oplysningerne på hver deres linje:
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);

            // 2. Tre Console.Write med newline karakter, med oplysningerne på hver deres linje:
            Console.Write(firstName + "\n");
            Console.Write(lastName + "\n");
            Console.Write(age + "\n");

            // 3 Èn Console.WriteLine, med oplysningerne på hver deres linje:
            Console.WriteLine(firstName + "\n" + lastName + "\n" + age);
            // og med interpolation:
            Console.WriteLine($"{firstName}\n{lastName}\n{age}");

            // 4 Èn Console.Write, med oplysningerne på hver deres linje:
            Console.Write(firstName + "\n" + lastName + "\n" + age + "\n");
            Console.Write($"{firstName}\n{lastName}\n{age}\n");


            //---------- OPGAVE 2.2 ----------
            // *** LÆRER NOTER: Vælg en string til titel. Vælg ikke en int til ISBN da tallet ikke kan være i en int datatype, vælg i stedet en long eller blot en string. Vælg en int til antal sider, men man kan også argumentere for en string da man ikke umiddelbart skal regne (plus, minus osv.) med  antallet af sider. Double er fint til pris, og man kan komme ind på afrundingsfejl her, kontra decimal datatypen som ikke har afrundingsfejl.
            string title = "Øl for kendere";
            string isbn = "9780007117116";
            int pages = 400;
            double price = 249.95;  // decimal price = 249.95m; // m'et angiver en decimal literal værdi, eller opfatter VS det som en double. 

            // Her demonstreres flere forskellige måder at outputte på. Man kan fint nøjes med interpolation i S1 undervisning:
            string outputInterpolation = $"Bogen hedder {title} og har ISBN nummer {isbn} og er {pages} sider lang og koster {price} kr.";
            string outputStringFormat = String.Format("Bogen hedder {0} og har ISBN nummer {1} og er {2} sider lang og koster {3} kr.", title, isbn, pages, price);
            string outputConcatenationOperator = "Bogen hedder " + title + " og har ISBN nummer " + " og er " + pages + " sider lang og koster " + price + "kr.";
            Console.WriteLine(outputInterpolation);


            //---------- OPGAVE 2.3 ----------
            // *** LÆRER NOTER: Her vises hvordan man bruger .NET datatyper (Int32, Double) istedet for keywords int og double. Der anvendes også interpolation. Samme fremgangsmåde for resten af maksimum og minimum værdierne til de andre tal datatyper. 
            string maxIntOutput = $"{Int32.MaxValue}";
            string minDoubleValue = $"{Double.MinValue}";
            Console.WriteLine(maxIntOutput);
            Console.WriteLine(minDoubleValue);
            
            //Som hyggelig bonus opgave kan man prøve følgende:
            int x = Int32.MaxValue; // tildel max værdi til en variabel.
            x = x + 1;              // Læg 1 til variablens værdi.
            Console.WriteLine(x);   // Vi får nu mindste værdien for datatypen - fordi der sker et såkaldt overflow. Dette er faktisk tilladt i C# (med mindre man anvender en såkaldt chekced block, som vil forhindre disse overflows.
        }
    }
}