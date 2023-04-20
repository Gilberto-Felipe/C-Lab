namespace GuestBook
{
    public class Guest
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Guest Book. \nPlease enjoy your time.");
            Console.WriteLine("****************************************************\n");
        }

        public static string GetGuestName()
        {
            string output;

            do
            {
                Console.Write("What is your name? ");

                output = Console.ReadLine();

            } while (output == "");

            return output;
        }

        public static int GetGuestParty()
        {
            int number;
            bool isNumber;

            do
            {
                Console.Write("How many people are in your party? ");

                string numberText = Console.ReadLine();

                isNumber = int.TryParse(numberText, out number);

                if (isNumber == false || number < 1)
                {
                    Console.WriteLine("Please, provide a valid number.");
                }
            } while (isNumber == false || number < 1);

            return number;
        }

        public static Dictionary<string, int> GetAllGuests()
        {
            string guestName;
            int partyNumber;
            Dictionary<string, int> output = new();

            do
        {
                guestName = GetGuestName();

                if (guestName.ToLower() != "none")
                {
                    partyNumber = GetGuestParty();

                    output.Add(guestName, partyNumber);
                }

            } while (guestName.ToLower() != "none");

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

        public static void GoodBye()
        {
            Console.WriteLine("Thank you for visiting us. We hope you had a wonderfull experience. \nGood bye!\n");
            Console.WriteLine("****************************************************");
        }
    }
}
