// Homework 7 List App


//Tasks:
//Welcome to the app.
//Ask for the student name in a loop.
//If the name == none stop the list
//Count the number of students in the list.
//Print the result to console.
//Test the App


Console.WriteLine("Welcome my friend to my List Roster App!\n");

string? firstName = string.Empty;

var names = new List<string>();

Console.WriteLine("Instructions: \n1. Write a name to fill the list. \n2. For finishing the list, write sic 'none'.\n");
do
{
    Console.Write("What is your name?: ");

    firstName = Console.ReadLine();

    if (firstName != "NONE".ToLower())
    {
        names.Add(firstName);
    }

    Console.WriteLine();

} while (firstName.ToLower() != "NONE".ToLower());

Console.WriteLine($"The total of students is {names.Count}\n");

Console.WriteLine("Good bye!");


