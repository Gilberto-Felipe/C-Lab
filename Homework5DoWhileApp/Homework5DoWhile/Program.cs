// Homework 5 Do While Loop

// Welcome to the app
// Preguntar por los nombres una y otra vez, hasta que el usuario escriba exit.
// Si el usuario es Tim, entonces imprimir Welcome Professor {firstname}
// Terminar cuando presionen "exit"

string? firstName = string.Empty;

Console.WriteLine("Hello friends welcome to my APP\n");

do
{
    Console.Write("What is your name: ");

    firstName = Console.ReadLine();

    if (firstName.ToLower() == "exit")
    {
        continue;
    }
    else if (firstName.ToLower() == "tim")
    {
        Console.WriteLine($"\nWelcome Professor {firstName}.\n");
    }
    else
    {
        Console.WriteLine($"\nWelcome student {firstName}.\n");
    }

} while (firstName != "exit");

