using System;
using System.Collections.Generic;

namespace Demo_MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Filmprogrammet.");
            RunMenu();
        }

        static void RunMenu()
        {
            bool correctInput = false;
            int menuChoice = 0;

            while(!correctInput)
            {
                // Vis menu:
                Console.WriteLine("1. Vis alle film");
                Console.WriteLine("2. Indtast ny film");
                Console.WriteLine("3. Søg på titel");
                Console.WriteLine("4. Afslut");

                // Hent input til menuvalg:
                string choice = Console.ReadLine();
                if(!Int32.TryParse(choice, out menuChoice))
                {
                    Console.WriteLine("Input ikke gendkendt som et tal. Prøv igen.");
                }
                else if(menuChoice > 0 && menuChoice < 5)
                {
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Menupunktet findes ikke. Prøv igen");
                }
            }

            // Behandl korrekt menuvalg
            if(menuChoice == 1)
            {
                DisplayAllMovies();
            }
            else if(menuChoice == 2)
            {
                CreateNewMovie();
            }
            else if(menuChoice == 3)
            {
                SearchMovie();
            }
            else
            {
                Console.WriteLine("Farvel og tak");
                return; // til main
            }
        }

        static void DisplayAllMovies()
        {
            Console.WriteLine("Viser alle film:");
            // Vis film
            Console.WriteLine("Tast vilkålig tast for at vende tilbage til menuen.");
            Console.ReadLine();
            RunMenu();
        }

        static void SearchMovie()
        {
            Console.WriteLine("Indtast titel:");
            string searchTerm = Console.ReadLine();
            // 1. hent alle film
            // 2. 

            RunMenu();
        }

        static void CreateNewMovie()
        {
            Console.WriteLine("Ny film:");
            RunMenu();
        }

        static List<string> GetAllMovies(string path)
        {

        }
    }
}