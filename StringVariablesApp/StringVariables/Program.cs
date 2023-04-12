

// Declares a variable with a starting value
string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

// Assigns value
firstName = "Gil";
lastName = "Ramirez";


// escape char \
//filePath = "C:\\Temp\\Demo \\n \\n";


// @"" string litteral - the way to do not use escpape \
filePath = @"C:\Temp\Demo \n";

// concatenates strings - difficult to read
Console.WriteLine(firstName + ' ' + lastName);

Console.WriteLine();

// concatenates strig passing parameters to the string
Console.WriteLine("{0} {1}", firstName, lastName);

Console.WriteLine();

// concatenates through string interpolation - the best way
Console.WriteLine($"Hello {firstName} {lastName}");

// testing escape char \ and @ string literal
Console.Write(filePath);

Console.WriteLine("Hellooou my friend");

// mixing @ litteral and $"" string interpolation 
string testString = @$"The file for {firstName} is at C:\SampleFiles";
Console.WriteLine(testString);



/// APUNTES 

/// manipulating string is expensive +10,000 records.
// every time you manipulate a string, the system creates a copy of the variable.

/// Garbage collector 
// the system should remove the useless copies of the string variables through the garbage collector.

/// Escape character \
// The scape character \ indica que el siguiente caracter principal debe ser interpretado como un caracter literal, no especial.
// Entonces \\ indica que la segunda \ es literal. Solo imprime una \.

/// @"" string litteral character
// @"" indica que todo el string es literal. Ya no necesita el \ caracter especial de escape. Si encuentra una \ significa la diagonal invertida, no el caracter especial escape '\'. Es una opción más elegante que usar el caracter escape \.

/// No se pueden mezclar la @ string literal y el \ escape. Debes de elegir cual usar.

/// @ literal y $ interpolacion 
// se pueden mezclar. Es una excepcion a la regla.
// el orden @$ no importa, ambos es valido {@$ o $@}


/// Variablese camelCase standard
// las variables se llaman con el standard camelCase, primera palabra minúsculas, segunda palabra Mayúsculas. 'expertsExchange'
// sin camelCase =  'expertsexchange' ... expert sex change ?


/// Variable naming Consejos

// Las variables deben tener un nombre descriptivo para los humanos. x o a no dicen nada. Eso es un problema para el desarrollo y mantenimiento de software.

// Los nombres kilometricos en las variables, pueden ser ridiculos pero no afectan el rendimiento. Para la computadora no importan. Ella sustituye los nombres de las variables por código eficiente para la máquina. No impacta en el rendimiento. Así, no use como nombre x, a, z.

// El balance es importante... ni tan corto que no se entienda, ni tan largo que sea una telenovela. 2 o 3 palabras es suficiente. 

// No usar abreviaciones. Son malas, se prestan a confusión. Por ejemplo, fName que significa: firstName, o fullName...

// No a la notación húngara... Mala práctica
















