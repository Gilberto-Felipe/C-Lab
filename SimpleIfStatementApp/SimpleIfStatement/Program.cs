
// If - Else Statement

/// If statements serves to make decisions. 
/// It evaluates if a condition is true, and do some actions.
/// It allows us to have different branches or ways of actions depending on a condition.
/// It imitates the our human intelligence. 
/// 

/// if always evaluates if the expression is true
/// else evaluates the opposite.
/// else is optional
/// 


/// Best Practices
/// Allways use the {} to scope the code.
/// If the body of the condition only has 1 sentence, then you can remove the curly braces {}. However, do that creates confussion.
/// Thus, allways use the {}
/// 


// Comparison equal operator ==
/// == means equal comparisson
/// 

Console.Write("What is your first name? > ");

string? firstName = Console.ReadLine();

if (firstName == "Gil")
{
    Console.WriteLine("Hello Mr. Ramirez.");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}



// Variables and scope
/// Variables have a scope. They live inside a block of code.
/// If a varible if declare inside a block of code, for example an if, you can only use and access its value inside that if block of code.
/// Be carefull.



// Bad practice

if (firstName == "")
    Console.WriteLine("Good bye");



// .ToLower()...
/// Doesn't modify the variable. 
/// It creates a copy in memory, but it does not affect the original value.
/// So you can use the original value in other places.



if (firstName.ToLower() == "gil")
{
    Console.WriteLine("Hello Mr. Ramirez. Second Time.");
}
else
{
    Console.WriteLine($"Hello {firstName}./");
}


// Ctr + K + D to format


// Never trust the Users
/// Allways spect the unspected. Think in different ways/cases the user can do a mess in the data, in the code.
/// What happen if...
/// 
