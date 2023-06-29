using System;
using static ExtensionMethodsMini.ConsoleUIMessages;

namespace ExtensionMethodsMini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Welcom to the ATM".PrintInConsole();

            ClientModel client = AccessAccount();

            $"Hello {client.FirstName}".PrintInConsole();

            do
            {
                ShowMainMenu();
                ChooseOption(client);
            } while (true);
        }
    }
}
