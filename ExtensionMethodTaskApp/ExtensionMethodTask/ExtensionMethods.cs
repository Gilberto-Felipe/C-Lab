using System;

namespace ExtensionMethodTask
{
    internal static class ExtensionMethods
    {
        public static PersonModel DefaultAge(this PersonModel person, int age)
        {
            person.Age = age;
            return person;
        }

        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"First name: { person.FirstName } \nLast name: { person.LastName } \nEmail: { person.Email } \nAge:{ person.Age }");
        }
    }
}
