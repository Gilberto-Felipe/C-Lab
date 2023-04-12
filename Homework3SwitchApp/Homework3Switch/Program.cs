// Homework 3 Switch App

//Tasks
//- Welcome the user
Console.WriteLine("Hello friend! \n");

//- Ask for the first name
Console.Write("What is your name: ");

//- Capture the input
string? firstName = Console.ReadLine();

Console.WriteLine();

//- If the user is Tim or TIM print "Welcome Professor"
//- Otherwise, print "Welcome student"


switch (firstName.ToLower())
{
	case "tim" or "timothy":
        Console.WriteLine("Welcome Professor.");
		break;
    default:
		Console.WriteLine("Welcome student.");
		break;
}


if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
{
    Console.WriteLine("Hello dear Professor.");
}
else
{
    Console.WriteLine("Nah... Hello fellow student.");
}


