using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClasses
{
    public static class Data
    {
        public static void GetPersonalData(Person person)
        {
            var address = new Address();

            Console.Write("What is your first name? ");

            person.FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");

            person.LastName = Console.ReadLine();

            Console.Write("What is your email? ");

            person.Email = Console.ReadLine();

            Console.Write("What is your street? ");

            address.Street = Console.ReadLine();

            Console.Write("What is your postal code? ");

            address.PostalCode = Console.ReadLine();

            Console.Write("What is your City? ");

            address.City = Console.ReadLine();

            Console.Write("What is your Country? ");

            address.Country = Console.ReadLine();

            person.Address = address;
        }
    }
}
