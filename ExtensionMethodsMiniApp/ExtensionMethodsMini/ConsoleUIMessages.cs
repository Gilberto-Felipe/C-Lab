using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATMMiniLibrary;
using System.Threading.Tasks;
using ATMMiniLibrary.DataAccess;

namespace ExtensionMethodsMini
{
    public static class ConsoleUIMessages
    {
        public static void PrintInConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static string ReadLineMasked(char mask = '*')
        {
            var sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write(mask);
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && sb.Length > 0)
                {
                    sb.Length--;
                    Console.Write("\b \b");
                }
            }

            Console.WriteLine();

            return sb.ToString();
        }

        public static ClientModel AccessAccount()
        {
            int counter = 3;
            ClientModel client;

            bool isValid;
            do
            {
                var nip = ReadNIP();

                (isValid, client) = AtmTransactions.ValidateNIP(nip);
                counter--;

                if (isValid)
                {
                    break;
                }

                if (counter == 0)
                {
                    "Your account was blocked. Please contact support to unlock it.".PrintInConsole();
                    CloseSession();
                }

            } while (isValid == false && counter > 0);

            return client;
        }

        public static string ReadNIP()
        {
            "Write your NIP".PrintInConsole();
            string output = ReadLineMasked();

            return output;
        }

        public static void CloseSession()
        {
            "Your session has been closed.".PrintInConsole();
            "Press a key to exit.".PrintInConsole();
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void ChooseOption(ClientModel client)
        {
            string entry = Console.ReadLine();
            decimal balance;

            switch (entry)
            {
                case "1":
                    balance = AtmTransactions.CheckBalance(client);
                    $"Balance account: $ { balance }".PrintInConsole();
                    break;
                case "2":
                    var quantityWithdraw = ValidateNumber();
                    AtmTransactions.DrawMoney(client, quantityWithdraw);
                    balance = AtmTransactions.CheckBalance(client);
                    $"New Balance account: $ { balance }".PrintInConsole();
                    break;
                case "3":
                    var quantityDeposit = ValidateNumber();
                    AtmTransactions.MakeDeposit(client, quantityDeposit);
                    balance = AtmTransactions.CheckBalance(client);
                    $"New Balance account: $ {balance}".PrintInConsole();
                    break;
                case "4":
                    CloseSession();
                    break;
                default:
                    ShowMainMenu();
                    break;
            }
        }

        public static void ShowMainMenu()
        {
            var menu = $"Main Menu\n" +
                            "1 - Check bank balance\n" +
                            "2 - Draw money\n" +
                            "3 - Make a deposit\n" +
                            "4 - Exit\n";

            menu.PrintInConsole();
        }

        private static decimal ValidateNumber()
        {
            decimal output;
            bool isValid;

            do
            {
                "Write the amount: ".PrintInConsole();
                string amount = Console.ReadLine();

                isValid = decimal.TryParse(amount, out output);

                if (isValid && output > 0)
                {
                    break;
                }

                "Write a valid number".PrintInConsole();

            } while (isValid == false);

            return output;
        }
    }
}
