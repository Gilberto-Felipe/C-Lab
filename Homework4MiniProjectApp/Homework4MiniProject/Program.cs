// Homework 4 Mini Project

// variables
string? firstName = string.Empty;
int age = 0;


// Welcomes the user
Console.WriteLine("Hello friend!\n");



// Asks for the first name
Console.Write("What is your first name: ");

firstName = Console.ReadLine();

Console.WriteLine();


// If the name i Bob or Sue, print Welcome Professor.	
// Else...
if (firstName.ToLower() == "bob" || firstName.ToLower() == "Sue")
{
    Console.WriteLine($"Welcome Profesor {firstName}.\n");
}
else
{
    Console.WriteLine($"Wellcome dear and smart student student.\n");
}



// Ask for age
Console.Write("How old are you? ");
string? ageText = Console.ReadLine();

Console.WriteLine();

// Convert input string to text
bool isAgeValid = int.TryParse(ageText, out age);

if (!isAgeValid || age < 0)
{
    Console.WriteLine("Sorry, invalid age format. Try again.\n");
    return;
}


// Compare the age of the user against 21.

if (age >= 0 && age < 21)
{
	Console.WriteLine($"Sorry, you need to wait {21-age} year.\n");
}
else
{
    Console.WriteLine($"Congrats! You can take the course.\n");
}

Console.WriteLine("Enjoy your day. Bye.");

