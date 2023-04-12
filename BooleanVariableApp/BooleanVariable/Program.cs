



/// Boolean 
/// 

// Booleans are variables that only could have two states> true or false.

/// use case
/// 

// Used in conditionals. 
// if true, do this; if false, do that.

// It is funny to print. 

bool isComplete = false;

Console.WriteLine($"Original value {isComplete}"); // False


/// ! not key flips the value of the boolean
/// for example
/// 
Console.WriteLine($"Flipped value with not operator {!isComplete}"); // True

// Operator not ! changes the value of the boolean to the opposite.
// not means the opposite of 

bool isTrue = true;
float result = 4F;

if ( 2 + 3 == result ) Console.WriteLine(isTrue);
else Console.WriteLine(!isTrue);


