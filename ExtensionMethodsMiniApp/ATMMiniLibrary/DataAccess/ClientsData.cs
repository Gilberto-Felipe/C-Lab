using ExtensionMethodsMini;
using System.Collections.Generic;

namespace ATMMiniLibrary.DataAccess
{
    public static class ClientsData
    {
        public static List<ClientModel> database = new List<ClientModel>()
        {
            new ClientModel
            {
                FirstName = "Maria",
                LastName = "Petrova",
                BankAccount = "0001",
                NIP = "2022",
                MoneyAmount = 100,
            },
            new ClientModel
            {
                FirstName = "Morgan",
                LastName = "Freeman",
                BankAccount = "0002",
                NIP = "4444",
                MoneyAmount = 1000,
            },
            new ClientModel
            {
                FirstName = "Taylor",
                LastName = "Swift",
                BankAccount = "0003",
                NIP = "1802",
                MoneyAmount = 500,
            }
        };
    }
}
