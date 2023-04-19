using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    public class ConsoleMessages
    {
        // Tuplas se definien con (<t>,<t>), ponenes entre parétesis los 2, 3... valores que quieres retornar

        public static (string, string) GetFullName()
        {
            Console.Write("What is your first name? ");

            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");

            string lastName = Console.ReadLine();

            // raro...
            // return firstName + " " + lastName;

            // mejor opción retornar una tupla
            return (firstName, lastName);
        }
    }
}
