

// Type Conversions

/// 
/// 

Console.Write("What is your age: ");

string? ageText = Console.ReadLine();


/// Parse 
/// It works from string to numbers... int, float, double, decimal, etc.
/// 
/// Parse Method is exact. If the input or value does not match the format of the value the app will crased. We'll have an Exception. 
/// It stops the app. Because the information is wrong. 
/// It will affect our processes... 
/// 

int age = int.Parse(ageText);

Console.WriteLine(age + 15);

Console.WriteLine("========== \n");

/// string to Int by TryParse
/// TryParse also works from string to numbers
/// 
/// Try is to Validate the user input.
/// Try will try to do the op. But it could failed.
/// It returns a boolean: True if passed, False if not passed.
/// The App will not crash, then you can handle the Exception in your code.
/// 

bool isValid = int.TryParse(ageText, out int age2);

Console.WriteLine(isValid);
Console.WriteLine(age2);

Console.WriteLine($"This is valid: {isValid}. The number was {age2}");


/// TryParse variable output
/// The variable output could be declare inline in 1 step> out int age2.
/// Or in two steps > 
/// int age2:
/// ... out age2);
/// 


/// When to use Parse or TryParse
/// It depends. 
/// Some times you want to stop your app if the Exception is crucial > Parse.
/// Some times you want to continue and handle the Exception > TryParse.



/// Convertion with Cast
/// Cast is the process of converting an expression of one data type to another.
/// There are two types of casting: Implicit and Explicit.
/// 
/// Implicit: the casting is automatic. The compiler do it for us.
/// If the target data type is wider than the origin usualy is automatic.
/// E.g. int > double.
/// 
/// Explicit: You need to doit using a cast operator (<data type original>) when the target is narrower thant the original data type.
/// E.g. double variable > (int)variable
/// E.g. decimal variable > (decimal)double
/// the reason is if the origin could loose data you need to confirmed by Explicit Casting.
/// 
/// Be aware that Casting could prodruce runtime errors or unexpected behaviours.
/// 


/// Implicit casting
/// 
double testDouble = age;
Console.WriteLine($"Implicit Casting int > double {testDouble}");


/// Explicit casting
/// 
decimal testDecimal = (decimal)testDouble;
Console.WriteLine($"Explicit Casting double > decimal {testDecimal}");

