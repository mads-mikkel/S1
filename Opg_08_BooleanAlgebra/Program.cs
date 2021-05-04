using System;
using System.Collections.Generic;

namespace Opg_08_BooleanAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 2;
            //int b = 4;

            //Console.WriteLine($"1: a==b || a > 0: {a == b || a > 0}");  // a == b => F, a > 0 => T. F || T => T
            //Console.WriteLine($"2. a+b >0 && a>0: {a + b > 0 && a > 0}");   // a + b > 0 => T, a > 0 => T. T && T => T
            //Console.WriteLine($"3. a != 5 && a+b >0: {a != 5 && a + b > 0}");   // a != 5 => T, a + b > 0 => T, T && T
            //Console.WriteLine($"4. (true || false) && a > b: {(true || false) && a > b}");
            //Console.WriteLine($"5. 3 > 5 && true || a == b: {3 > 5 && true || a == b}");
            //Console.WriteLine($"6. b > a && true || false || b > 4: {b > a && true || false || b > 4}");
            //Console.WriteLine($"7. b < 4 && a < b || a + b > 4 && true: {b < 4 && a < b || a + b > 4 && true}");
            //Console.WriteLine($"8. true && true || false: {true && true || false}");
            //Console.WriteLine($"9. true && false && true: {true && false && true}");
            //Console.WriteLine($"10. true || false || false: {true || false || false}");
            //Console.WriteLine($"11. false && false: {false && false}");
            //Console.WriteLine($"12. a == 3 && b > 4 || a + 3 > b: {a == 3 && b > 4 || a + 3 > b}");
            //Console.WriteLine($"13. a > b && b < a && a + a == b: {a > b && b < a && a + a == b}");

            //Dictionary<string, int> kv = new();
            //kv.Add("Hvad er 5+5?", 10);

            //(string, int)[] arr = new (string, int)[5]
            //{
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10)
            //};

            //List<(string q, int a)> list = new()
            //{
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10),
            //    ("Hvad er 5+5?", 10)
            //};

            //int point = 0;
            //for(int j = 0; j < list.Count; j++)
            //{
            //    Console.WriteLine(list[j].q);
            //    string i = Console.ReadLine();
            //    if(list[j].a == 7)
            //    {
            //        Console.WriteLine("RIGTIGT");
            //        point++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Urig");
            //    }
            //}

            // Opg 9.1
            int a = 1;
            int b = 2;
            int c = 3;
            int x = 0;

            if(a == 1)
            {
                x = 1;
            }
            if(b == 1)
            {
                x = 2;
            }
            if(c == 3)
            {
                x = 3;
            }
            // x bliver 3

            // Opg 9.2
            x = 0;
            if(a != 1)
            {
                x = 1;
            }
            else if(b == 2)
            {

            }
        }
    }
}