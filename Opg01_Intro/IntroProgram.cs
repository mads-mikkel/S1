using System;
using System.Runtime.Versioning;

namespace Opg01_Intro
{
    class IntroProgram
    {
        [SupportedOSPlatform("windows")]
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WindowHeight = 10;
            Console.WindowWidth = 30;
            Console.WriteLine("Test");
        }
    }
}

