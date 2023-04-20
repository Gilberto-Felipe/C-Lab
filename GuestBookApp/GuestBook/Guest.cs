namespace GuestBook
{
    public class Guest
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Guest Book. Please enjoy the moment.");
        }

        public static string AskGuestName()
        {
            string output;

            do
            {
                Console.Write("What is your name? ");

                output = Console.ReadLine();

                if (output == "")
                {
                    Console.WriteLine("Please, write a name.");
                }

            } while (output == "");

            return output;
        }

        public static int AskGuestParty()
        {
            int number;
            bool isNumber;

            do
            {
                Console.Write("How many people are in your party? ");

                string numberText = Console.ReadLine();

                isNumber = int.TryParse(numberText, out number);

                if (isNumber == false)
                {
                    Console.WriteLine("Please, provide a valid number.");
                }
                else if (number < 1)
                {
                    Console.WriteLine("The number should be grater than 0.");
                }
            } while (isNumber == false || number < 1);

            return number;
        }

        public static Dictionary<string, int> AddEntry(Dictionary<string, int> output,string name, int total)
        {
            output.Add(name, total);

            return output;
        }

        public static void PrintReport(Dictionary<string, int> guestBook)
        {
            int sum = 0;
            foreach (var guest in guestBook)
            {
                Console.WriteLine(guest.Key);
                sum += guest.Value;
            }
            Console.WriteLine($"Total of people at the party {sum}");
        }
    }
}
