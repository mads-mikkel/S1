using System;
using System.Collections.Generic;

namespace Opg13_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new();
            c.Milage = -1;
            //Person p = new();
            //Car c1 = new() { Make = "McLaren", Model = "F1", Milage = 1045 };
            //Car c2 = new() { Make = "Mazda", Model = "sdfsdf", Milage = 1045 };
            //List<Car> cars = new() { c1, c2 };
            //p.Cars = cars;
        }
    }

    public class Person
    {
        public List<Car> Cars { get; set; }
    }

    public class Car
    {
        private int milage;
        public int Milage
        {
            get
            {
                return milage;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Milage));
                }
                milage = value;
            }
        }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}