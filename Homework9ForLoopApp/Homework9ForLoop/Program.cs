// Homework 9 FOR LOOPS


//Task
//Say Hello
//Ask the user for a comma-separated list of firts names (no spaces)
//Split the string into a string array.
//Loop through the array and print "Hello <name>" to the console for each person.
//say good bye


//Test

//Edga cases
//Array is empty -> error
//Array with 1 name -> ok
//Array with multiple names -> ok

//Revisar inicio y fin del array,
//zero base... inicia en 0, final es final-1


Console.WriteLine("Hello friend Welcome to my App\n ");

Console.WriteLine("Please, write a list of first names separated by commas. Do not use spaces between commas. \nGood example> Rogrigo,Gonzalo,Pedro... \nBad example> Juan , Santiago , Roel...\n");

string? firstNames = Console.ReadLine();

if (firstNames == null || firstNames == string.Empty || firstNames[0] == ',')
{
    Console.WriteLine("You didn't write any name :( !");
    return;
}

var names = firstNames.Split(',');

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Hello {names[i]}");
}

Console.WriteLine("\nSee you later!");

