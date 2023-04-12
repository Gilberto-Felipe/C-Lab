//Tasks




//And return the name of the user based on the ID.
//Say bye!



// Homework 8 Dictionary App


//Welcome the user.
Console.WriteLine("Hello, welcome to the Dicctionary App\n");


//Fill in a dictionary set with few records.
var employees = new Dictionary<int, string>();

employees.Add(1, "Alvaro Fuentes");
employees.Add(2, "Beto Cuevas");
employees.Add(3,"Carlos Armendaris");
employees.Add(4, "Dario Garcia");


//Ask the user for their ID.
Console.Write("Please write your ID number: ");

string? idText = Console.ReadLine();

bool isValid = int.TryParse(idText, out int id);

if (isValid == false)
{
    Console.WriteLine("The Id is not a valid number {0}. Sorry!", idText);
    return;
}

if (id > 0 && id < 5)
{
    Console.WriteLine($"\nValid Id #{id}, your user name is {employees[id]}");
}
else
{
    Console.WriteLine("\nThe ID is out of rage.");
}

Console.WriteLine("\nBye!");
