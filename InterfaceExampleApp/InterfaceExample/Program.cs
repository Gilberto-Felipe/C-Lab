using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var runners = new List<IRun>    
            {
                new AnimalModel(),
                new AnimalModel(),
                new PersonModel(),
                new PersonModel(),
            };

            foreach (var runner in runners)
            {
                if (runner is AnimalModel animal)
                {
                    animal.KilometersRun = 20;
                }
                if (runner is PersonModel person)
                {
                    person.Species = "Man";
                    person.KilometersRun = 10;
                }

                Console.WriteLine($"Animal run {runner.KilometersRun} Km.");
            }

            Console.ReadLine();
        }
    }

}
