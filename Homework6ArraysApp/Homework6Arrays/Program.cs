// Homework 6 Arrays


// Welcome the user
// Create an Array of 3 names
// Ask the user a number from 0 to 2.
// Convert the string input to a number (int.TryParse())
// Check for valid numbers -no other types...
//    - if not print an error message
// Check that numbers are in range.
//	 If number is out of bound, print an error message.
//	 If number is correct, Return the name that matches that number in the array.


// Test edge cases
// easy> a integer between 0 and 2
//	print the name
//> check the type agains: two with letters or other thing, decimals, characters, what ever the user wants.
//	print error message no valid age
//> check the range 0 and 2
//	print error message out of boundaries



string[] names = new string[] { "Carlos", "Alvaro", "Xochitl" };


Console.WriteLine("Hello friend, welcome to my APP!\n");

Console.Write("Please, write a whole number from 0 to 2: ");

string? numberText = Console.ReadLine();

bool isValidNumber = int.TryParse(numberText, out int number);

if (isValidNumber == false)
{
    Console.WriteLine($"\n{numberText} is not a whole number.");
}
else if (number < 0 || number > 2)
{
    Console.WriteLine($"\n{number} is out of range.");
}
else
{
    Console.WriteLine($"\nYour name will be {names[number]}"); 
}










