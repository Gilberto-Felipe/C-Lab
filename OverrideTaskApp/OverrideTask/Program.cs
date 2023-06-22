using System;

namespace OverrideTask
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel();

            Console.WriteLine("Hello!");

            Console.Write("What is your first name? ");
            person.FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            person.LastName = Console.ReadLine();

            Console.WriteLine($"Your full name is: { person }");

            Console.ReadLine();
        }
    }
}
