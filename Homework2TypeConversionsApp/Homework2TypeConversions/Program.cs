// Homework 2


//Capture a user's age from the Console and then identify how old they will be in 25 years, as well as how old they were 25 years ago. Print that information to the Console in natural language.


// Ask user's age
Console.WriteLine("Hello friend \n");

Console.Write("How old are you?: ");


// Capture user's age
string? text = Console.ReadLine();

bool isValidAge = int.TryParse(text, out int age);

Console.WriteLine($"\nThis is a {isValidAge} input. Your actual age is {age} \n");


// Do addition
int futureAge = age + 25;


// Do substraction
int pastAge = age - 25;


// Print in Console with natural language
Console.WriteLine($"In 25 years you'll be {futureAge}. \n" +
    $"25 years ago you were {pastAge}.");