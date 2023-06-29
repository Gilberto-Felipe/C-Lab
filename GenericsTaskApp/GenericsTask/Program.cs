using System;
using System.Collections.Generic;

namespace GenericsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printers = new List<Printer<string, int>>();

            var printer = new Printer<string, int>();

            printers.Add(printer);
            printers.Add(printer);
            printers.Add(printer);

            int counter = 1;
            int model = 9001;
            foreach (var item in printers)
            {
                printer.PrintingInfo($"Oister-{counter++}", model++);
            }

            Console.ReadLine();
        }

        internal class Printer<T, U>
        {
            public string Brand { get; set; }
            public int Model { get; set; }

            public void PrintingInfo(T item, U item2)
            {
                Console.WriteLine($"Brand: {item}; Model: {item2}");
            }
        }

    }
}
