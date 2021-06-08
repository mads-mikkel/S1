using System;
using System.IO;    // 1. Import af funktioner til filsystemet

namespace Demo_TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Stien til filen:
            string path = @"C:\Tests\files";
            
            // 3. filnavnet:
            string filename = "content.txt";

            // 4. Hele stien
            string fullPath = Path.Combine(path, filename);

            // 4B lav filen med førstegangsindhold
            string initialContent = "Opkvalificering til S1 er sjovt!";
            File.WriteAllText(fullPath, initialContent);

            // 5. Læs fra filen
            string content = File.ReadAllText(fullPath);
            Console.WriteLine(content);

            // 6. Tilføj til filens indhold
            string moreContent = "\nMen V1 og T1 var også sjovt!";
            File.AppendAllText(fullPath, moreContent);

            // 5 igen
            content = File.ReadAllText(fullPath);
            Console.WriteLine(content);

        }        
    }
}