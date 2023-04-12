// Dictionaries

/// Dictionary are used when
/// 1 you need to find values by a unique key: definitions, items by id, etc.
/// 2 you need to translate data between the key and value.
/// 

/// Dictionaries contains a set of item labeled by a key. So they are a pair of key and value.
/// The data is unordered.
/// They are easy to access.
/// 

/// Dictionaries are not used everywhere. 
/// They have a purpose. But when you need them, they are very helpful.

/// Declaration
/// Dictionary <T, T>
/// 

/// Reglas 
/// Las llaves son unicas

// Example of a diccionary to find definitions

Dictionary<string, string> diccionario =  new Dictionary<string, string>();

diccionario["alpha"] = "First letter of the Greek alphabet.";
diccionario["beta"] = "Second letter of the Greek alphabet.";
diccionario["omega"] = "Last letter of the Greek alphabet.";

Console.WriteLine($"Alpha is the {diccionario["alpha"]}");
Console.WriteLine($"Omega is the {diccionario["omega"]}");





// Example of finding an employee by Id

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[1] = "Jorge";
employees[2] = "Pancho";
employees[3] = "Perico";
employees[10] = "Aldus";

Console.WriteLine($"The Id 1 = {employees[1]}");
Console.WriteLine($"The Id 2 = {employees[2]}");
Console.WriteLine($"The Id 10 = {employees[10]}");



// Iterate a dictionary by key and values 

foreach (var employee in employees)
{
    Console.WriteLine("{0} {1}", employee.Key, employee.Value);
}

Console.WriteLine("End");


// Iterate a dictionary by key
foreach (var key in employees.Keys)
{
    Console.WriteLine("{0}", key);
}


// Iterate a dictionary by value
foreach (var value in employees.Values)
{
    Console.WriteLine("{0}", value);
}

