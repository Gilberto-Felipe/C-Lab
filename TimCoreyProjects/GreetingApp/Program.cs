// Greeting App

// Welcome the user
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Welcome friend to my app");
Console.WriteLine("This app was built by Gilberto Ramirez");
Console.WriteLine("--------------------------------------");
Console.WriteLine();

// Ask for the first name
Console.Write("What is your first name: ");

string? firstName = Console.ReadLine();

Console.WriteLine();

// Ask for the last name
Console.Write("What is your last name: ");

string? lastName = Console.ReadLine();

Console.WriteLine();

// Greet him by firstName
Console.WriteLine("Hello {0} {1}",firstName,lastName);

Console.WriteLine();


// Asks for your birthday and calculate your age
string? birthday;
DateTime birthdayDate;
bool isformatedOk;

do
{    
    Console.Write("Write your age in this format mm/dd/yyyy: ");

    birthday = Console.ReadLine();

    if (!DateTime.TryParseExact(birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdayDate))
    {
        Console.WriteLine("Your ages is not formatted correctly. Please, try again.");
        Console.WriteLine();
        isformatedOk = false;
    }
    else
    {
        Console.WriteLine();
        isformatedOk = true;
    }

} while (!isformatedOk);


//Calculates the age 
int age = DateTime.Now.Year - birthdayDate.Year;

if (birthdayDate > DateTime.Today.AddYears(-age))
{
    age--;
    Console.WriteLine($"Your age is {age}");
}
else if (birthdayDate == DateTime.Today.AddYears(-age))
{
    Console.WriteLine($"Happy {age}th birdthday {firstName}");
}

Console.WriteLine();

// Gets the actual date and time
Console.WriteLine($"The actual date and time is {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");

Console.WriteLine();

Console.Write("Good bye");

Console.ReadKey();