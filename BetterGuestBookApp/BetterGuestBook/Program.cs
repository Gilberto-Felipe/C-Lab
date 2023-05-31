// See https://aka.ms/new-console-template for more information

// Capture info about each guest 
// Assumption is at least one guest and unknown maxium
// info > first name, last name, number of people in the party, and message to the host
// Assumption there is no validation, whatever the user writes is ok
// validate that the number of people in the party is a valid number (more than 0 and a number)
// Once done, print the info of each guest through a loop


using GuestBookLibrary.Models;


var guests = new List<GuestModel>();

Welcome();

GetGuestsInfo(guests);

PrintSummaryGuests(guests);




static void Welcome()
{
    Console.WriteLine("Hello! Welcome to the Guest APP.");
    Console.WriteLine("*************************\n");
}

static int GetPartyNumber()
{
    bool isNumber;
    int output;
    bool isValid;

    do
    {
        Console.Write("How many people is in your party? : ");
        string strNumber = Console.ReadLine();

        isNumber = int.TryParse(strNumber, out output);

        isValid = isNumber && output > 0;

    } while (isValid == false);

    return output;
}

static void GetGuestsInfo(List<GuestModel> guests)
{
    string moreGuestsComming;

    do
    {
        var guest = new GuestModel();

        guest.FirstName = GetGuestData("What's your first name: ");

        guest.LastName = GetGuestData("What's your last name: ");

        guest.PeopleInParty = GetPartyNumber();

        guest.MessageToHost = GetGuestData("What's your message to the host? : ");

        guests.Add(guest);

        Console.Clear();

        Console.Write("Are more guests comming (yes/no)? ");
        moreGuestsComming = Console.ReadLine();

        Console.Clear();

    } while (moreGuestsComming.ToLower() == "yes");
}

static void PrintSummaryGuests(List<GuestModel> guests)
{
    foreach (var guest in guests)
    {
        Console.WriteLine(guest.GuestInfo);
        Console.WriteLine("********************\n");
    }
}

static string GetGuestData(string message)
{
    Console.Write(message);
    var output = Console.ReadLine();
    return output;
}
