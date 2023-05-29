using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes
{
    public static class UserMessages
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Hello my friend!\nWelcome to my awesome Directory app!");

            Console.WriteLine("Please, give me your Address");
        }

        public static void GoodBye()
        {
            Console.WriteLine("Sir, Have a good day. Good bye!");
        }

        public static void GetData(AddressModel address)
        {
            Console.Write("Write your street> ");

            address.Street = Console.ReadLine();

            Console.Write("Write your zip code> ");

            address.ZipCode = Console.ReadLine();

            Console.Write("Write your city> ");

            address.City = Console.ReadLine();

            Console.Write("Write your state> ");

            address.State = Console.ReadLine();

            Console.WriteLine("Sir, please, review your data: ");

            Console.WriteLine(address.Address);
        }

        public static void ReviewData(AddressModel address)
        {
            bool isCorrect = false;

            do
            {
                Console.Write("Is your personal address right? (y/n) ");

                var answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    GetData(address);
                    continue;
                }

                isCorrect = true;

            } while (isCorrect == false);
        }
    }
}
