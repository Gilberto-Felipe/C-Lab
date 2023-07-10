using Microsoft.Extensions.Configuration;
using DataAccessLibrary;
using DataAccessLibrary.Models;

string connectionString = GetConnectionString();

SqlCrud sql = new(connectionString);

ReadAllContacts(sql);

//ReadFullContactById(sql, 3);

//CreateNewContact(sql);

//UpdateContact(sql);

//RemoveNumberFromContact(sql, 1,1);



Console.WriteLine("Process Done!");

Console.ReadLine();



static string GetConnectionString(string connectionStringName = "Default")
{
    string output = "";

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

    var config = builder.Build();

    output = config.GetConnectionString(connectionStringName);

    return output;
}

static void ReadAllContacts(SqlCrud sql)
{
    sql.GetAllContacts().ForEach(contact =>
        Console.WriteLine($"{ contact.Id } : { contact.FirstName } { contact.LastName }"));
}

static void ReadFullContactById(SqlCrud sql, int id)
{
    var contact = sql.GetFullContactById(id);

    Console.WriteLine($"{contact.BasicInfo.Id} - {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
}

static void CreateNewContact(SqlCrud sql)
{
    FullContactModel contact = new()
    {
        BasicInfo = new BasicContactModel
        {
            FirstName = "Tatiana",
            LastName = "Ramirez"
        }
    };

    contact.EmailAddresses.Add(new EmailAddressModel { Email = "taty@chess.com" });
    contact.EmailAddresses.Add(new EmailAddressModel { Id = 2, Email = "felipe@hotmail.com" });

    contact.PhoneNumbers.Add(new PhoneNumberModel { Id = 1, Phone = "52-1234" });
    contact.PhoneNumbers.Add(new PhoneNumberModel { Phone = "39-8524" });

    sql.CreateContact(contact);
}

static void UpdateContact(SqlCrud sql)
{
    BasicContactModel contact = new() 
    { 
        Id = 3,
        FirstName = "Tatyana",
        LastName = "Kosintseva Ramirez"
    };

    sql.UpdateContactName(contact);
}

static void RemoveNumberFromContact(SqlCrud sql, int contactId, int phoneId)
{
    sql.RemovePhoneNumberFromContact(contactId, phoneId);
}

