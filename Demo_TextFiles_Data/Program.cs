using System;
using System.IO;

namespace Demo_TextFiles_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\tests\files\products.txt";
            PrintFile(path);
        }

        static void PrintFile(string path)
        {
            string header = "Nr.\tNavn\t\t\tPris\tAntal";
            Console.WriteLine(header);

            string content = File.ReadAllText(path);
            string[] lines = content.Split('\n');
            for(int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split('|');
                string line = $"{values[0]}   {values[1]}   {Convert.ToDecimal(values[2]):c2}   {values[3]}";
                Console.WriteLine(line);
            }
        }
    }
}
