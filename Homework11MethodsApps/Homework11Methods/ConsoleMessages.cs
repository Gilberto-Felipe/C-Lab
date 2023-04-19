namespace Homework11Methods
{
    public class ConsoleMessages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my app, friend!");
        }

        public static (string, string) AskName() 
        {
            Console.Write("What is your first name? ");

            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");

            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }

        public static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine($"Hi {lastName} {firstName}. It's a pleasure.");
        }
    }
}
