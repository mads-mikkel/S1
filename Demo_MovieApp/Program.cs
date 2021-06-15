using System;
using System.Collections.Generic;
using System.IO;

namespace Demo_MovieApp
{
    class Program
    {
        static string path = @"c:\tests\files\movies.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til filmprogrammet!");
            RunMenu();
            Console.WriteLine("Farvel og tak!");
        }

        static void RunMenu()
        {
            bool correctInput = false;
            int menuChoice = 0;

            // Valider bruger input
            while(!correctInput)
            {
                Console.WriteLine("1. Vis alle film");
                Console.WriteLine("2. Indtast ny film");
                Console.WriteLine("3. Søg på titel");
                Console.WriteLine("4. Afslut");

                // Hent input til menuvalg
                string choice = Console.ReadLine();
                if(!Int32.TryParse(choice, out menuChoice))
                {
                    Console.WriteLine("Input ikke genkendt, prøv igen.");
                }
                else if(menuChoice > 0 && menuChoice < 5)
                {
                    // OK
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Menupunktet findes ikke");
                }
            }

            // Behandl menuvalg:
            if(menuChoice == 1)
            {
                DisplayAllMovies();
            }
            else if(menuChoice == 2)
            {
                AddNewMovie();
            }
            else if(menuChoice == 3)
            {
                SearchMovie();
            }
            else
            {
                return;
            }
        }

        static void SearchMovie()
        {
            Console.Write("Søgning: ");
            string searchTerm = Console.ReadLine();

            List<string> movies = GetAllMovies();
            List<string> matchingMovies = new();

            foreach(string movie in movies)
            {
                string title = movie.Split('|')[0];
                if(title.Contains(searchTerm))
                {
                    matchingMovies.Add(movie);
                }
            }

            Console.WriteLine($"Der blev fundet {matchingMovies.Count} match:");
            Print(matchingMovies);
            ReturnToMenu();
        }

        static void AddNewMovie()
        {
            Console.Write("Titel: ");
            string title = Console.ReadLine();

            int year;   // indeholder året. Skal erklæres FØR løkken, da den skal bruges EFTER løkken.
            bool done = false;  // Betingelse for om brugeren har indtastet noget gyldigt.

            // Løkke til at verificere om brugeren har indtastet noget gyldigt eller ej. Løkken afsluttes når brugeren har indtastet noget gyldigt.
            do
            {
                Console.Write("År: ");
                string yearInput = Console.ReadLine();
                if(!Int32.TryParse(yearInput, out year))    // year variablen sendes ind i TryParse, og hvis teksten yearInput kan konverteres til et tal, bliver dette tal tildelt year variablen, som kan anvendes senere i programmet.
                {
                    Console.WriteLine("Kan ikke konvertere til årstal. Prøv igen.");
                }
                else
                {
                    int min = 1888;     // Første film ever.
                    int max = DateTime.Today.AddYears(3).Year;  // Nu + 3 år
                    if(year < 1888 || year > max)
                    {
                        Console.WriteLine($"Årstallet skal være mellem {min} og {max}.");
                    }
                    else
                    {
                        done = true;    // Hvis vi når hertil, har brugerne indtastet noget gyldigt og vi kan afslutte løkken.
                    }
                }
            } while(!done);

            Console.Write("Instruktør: ");
            string director = Console.ReadLine();

            Console.Write("Selskab: ");
            string company = Console.ReadLine();

            string movie = $"\n{title}|{year}|{director}|{company}";
            File.AppendAllText(path, movie);

            ReturnToMenu("Filmen blev tilføjet");
        }

        static void DisplayAllMovies()
        {
            // 1. Hent alle film fra tekstfilen
            List<string> movies = GetAllMovies();

            // 2. iterér over alle film og udskriv til konsol
            Print(movies);

            // 3. Returner til RunMenu metoden
            ReturnToMenu();
        }

        static List<string> GetAllMovies()
        {
            // Brug File klassen til at hente alle film fra tekstfilen.
            List<string> movies = new();
            string text = File.ReadAllText(path);
            string[] lines = text.Split('\n');
            foreach(string line in lines)
            {
                movies.Add(line);
            }
            return movies;
        }

        static void Print(List<string> movies)
        {
            // Lav en løkke der itererer over alle strings listen og udskriv dem på en pæn måde.
            string formatSpecifier = "{0,-5}{1,-40}{2,-10}{3,-20}{4,-20}";
            Console.WriteLine(formatSpecifier, "Nr.", "Titel", "År", "Instruktør", "Selskab");

            for(int i = 0; i < movies.Count; i++)
            {
                string line = movies[i];
                string[] parts = line.Split('|');
                Console.WriteLine(formatSpecifier, i + 1, parts[0], parts[1], parts[2], parts[3]);
            }
        }

        static void ReturnToMenu(string text = "")
        {
            if(text != "")
            {
                text += " .";
            }
            Console.Write($"{text}Tast ENTER for at returnere til menuen.");
            Console.ReadLine();
            RunMenu();
        }
    }
}