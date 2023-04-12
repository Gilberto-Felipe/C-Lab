// Advanced if statements

Console.Write("What is your name: ");

string? firstName = Console.ReadLine();

Console.Write("What is your last name: ");

string? lastName = Console.ReadLine();


// Condicion doble
/// Podemos encadenar condiciones con operadores lógicos
/// AND = && both conditions must be true
/// OR = || at least one condition must be true
/// 

if (firstName.ToLower() == "gil" && lastName.ToLower() == "ramirez")
{
    Console.WriteLine("Hello Mr. Ramirez");
}
else if (firstName.ToLower() == "gil")
{
    Console.WriteLine("You have a cool first name.");
}
else if (lastName.ToLower() == "ramirez")
{
    Console.WriteLine("You have a great last name.");
}
else
{
    Console.WriteLine("Sorry, you don't have a cooler name!");
}


// chain if - else if - else
/// Else if chain the conditional statements and only executes the branch/block of code that evaluates to true.
/// 
/// They are branches of code. If of them is true, its block of code is executed. 
/// The others blocks of code no. 
/// It choose what code block to run based upon the condition == true.
/// Else runs if the others conditional blocks fail. It is like a default case.
/// 


if (firstName.ToLower() == "rosa") 
{
    Console.WriteLine("That's a normal name.");
}

if (string.IsNullOrEmpty(lastName))
{
    Console.WriteLine("You didn't write your last name.");
} 
else
{
    Console.WriteLine("You wrote your last name.");
}


// Separate if - if 
/// Many if statement next to each other are no chain.
/// Each statement will run if they are true. 
/// If you want to chain the conditionals, and only run the branch that is true, you need the if - else if statement.
/// All if statements will be evaluated... 
/// 

if (lastName.ToLower() != "gilberto")
{
    Console.WriteLine("Luck for next time.");
}

if (!string.IsNullOrEmpty(firstName) && firstName == "Juan")
{
    Console.WriteLine("Such a common name.");
}

if (firstName.ToUpper() == "GIL" || firstName.ToLower() == "gil")
{
    Console.WriteLine("What a wonderful name");
}



// Comparison operator ==
/// A mistake everybody do... use = to compare...
/// No, = is the asign operator.
/// To compare use ==
/// Read the hints of the vs intellisense
/// 


// Relational operators
/// ==, >, >=, <, <=, != (not equal)

Console.Write("How old are you? ");

string? ageText = Console.ReadLine();

bool isAgeValid = int.TryParse(ageText, out int age);

if (isAgeValid)
{
    if (age == 0)
    {
        Console.WriteLine("You're a baby.");
    }
    else if (age >= 1 && age < 10)
    {
        Console.WriteLine("You're a kid.");
    }
    else if (age >= 10 && age < 21)
    {
        Console.WriteLine("You're a teenager.");
    }
    else if (age >= 21 && age <= 30)
    {
        Console.WriteLine("You're a young man.");
    }
    else if (age > 30 && age <= 65)
    {
        Console.WriteLine("You're a man.");
    }
    else 
    {
        Console.WriteLine("You're old.");            
    }
}


// () agroups operations or set of operations

if ((age >= 40 && age < 50) || (age >= 70 && age < 80))
{
    Console.WriteLine("You're in your 40's or 70's.");
}
/// They help human developers to understand the code.
/// Code exists to be read by humans, no for machines.
/// Use () when there are more than 3 different operators (mix of &&s and ||s)
/// If all operations are of the same type (i.e. all &&), you don't need ().
/// 

