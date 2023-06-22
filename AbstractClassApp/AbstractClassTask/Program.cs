using System;
using System.Collections.Generic;

namespace AbstractClassTask
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto>()
            {
                new Auto() { VIN = 0000-1234-8888, Manufacturer = "Toyota", Model = "Corola", Year = "2023", Color = "White", Quantity = 1 },
                new Auto() { VIN = 0000-1234-8888, Manufacturer = "VolksWagen", Model = "Jetta", Year = "2005", Color = "White", Quantity = 1 }
            };

            foreach (var auto in autos)
            {
                Console.WriteLine($"{ auto.Manufacturer } { auto.Model }");
            }

            Console.ReadLine();
        }
    }
}
