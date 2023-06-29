using ATMMiniLibrary.DataAccess;
using ExtensionMethodsMini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMiniLibrary
{
    public static class AtmTransactions
    {
        public static (bool, ClientModel) ValidateNIP(string nip)
        {
            var clients = ClientsData.database;
            bool isValidNIP = false;

            try
            {
                isValidNIP = clients.Any(n => n.NIP.Equals(nip));

                var client = clients.Single(n => n.NIP.Equals(nip));

                return (isValidNIP, client);
            }
            catch (Exception)
            {
                isValidNIP = false;
                return (false, null);
            }
        }

        public static decimal CheckBalance(ClientModel client)
        {
            decimal balance = client.MoneyAmount;

            return balance;

        }

        public static void DrawMoney(ClientModel client, decimal quantity)
        {
            client.MoneyAmount -= quantity;
        }

        public static void MakeDeposit(ClientModel client, decimal quantity)
        {
            client.MoneyAmount += quantity;
        }


    }
}
