// Homework 10 Foreach


//Ask the user for their first name. Continue asking for firts names until there are no more. Then loop through each name using foreach and tell each person hello on the Conosle.


//tasks
//Ask the user for their first name
//Continue asking for firts names until there are no more
//loop through each name using foreach
//tell each person hello on the Conosle.


//Test Edge Cases

//No name
//more than 1 name



Console.WriteLine("Hello friend, welcome to my App \n");

string? firstName = string.Empty;
List<string>? names = new();

do
{
    Console.Write("What is your name? ");

    firstName = Console.ReadLine();

    names.Add(firstName);

} while (firstName != string.Empty);


foreach (string name in names)
{
    if (name != string.Empty)
    {
        Console.WriteLine($"Hello {name}!");
    }
}

Console.WriteLine("\nGood bye!");


