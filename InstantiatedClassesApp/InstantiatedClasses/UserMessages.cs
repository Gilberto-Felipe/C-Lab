using System.Reflection;

namespace InstantiatedClasses
{
    public static class UserMessages
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcom to my DirectoryApp my friend!");
            Console.WriteLine("Please, give me your info:");
        }

        public static void Goodbye()
        {
            Console.WriteLine("That's it. Thank you. Good bye!");
        }

        public static void PrintData(Person person)
        {
            Console.WriteLine("Please, Review your data.");

            Console.WriteLine($"First name: {person.FirstName}\nLast name: {person.LastName}\nEmail: {person.Email}\nStreet: {person.Address.Street}\nPostal Code: {person.Address.PostalCode}\nCity: {person.Address.City}\nCountry: {person.Address.Country}");
        }
    }
}
