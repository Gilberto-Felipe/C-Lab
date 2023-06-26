using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel()
            {
                FirstName = "Juan",
                LastName = "Perez",
                Email = "jperez@gmail.com"                
            };

            person.DefaultAge(18).PrintInfo();

            Console.ReadLine();          
        }
    }
}
