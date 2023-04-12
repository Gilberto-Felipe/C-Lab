
/// Decimal Type
/// 

// It stores fractional numbers, it is numbers with decimal as double.
// The difference is the resources it consume.


// double = 8 bytes - its precision is to 15 digits 00000000 x8

// decimal = 16 bytes - its precision is to 28 digits 00000000 x32

// decimal consumes huge more memory than double. It is not the double of the bytes... it is much more... 


/// case of use
/// 

// double is for math operations. 
// All the math libraries are build upon double.

// decimal is for money or astronomic calcultions. For example if you work for the Nasa...


/// operations
/// 

// double all operations

// decimal normally, addition and substraction



/// values

// double - 4.12, 5.0, 32, 1.234

// decimal - 4.12, 5.0, 32, 1.234

// the same values could be doubles or decimals. But the compailer did not know, so when we hardcoded the values (write litteral values) we need to specify the compiler when is decimal.

double sum = 123.951D;

decimal bankAccount = 123.951M;

// We use M to specify the compiler that the value is decimal.
// think of the M as money...

// With doubles the D tells the value is double.

Console.WriteLine($"This is a double {sum}");

Console.WriteLine($"This is a decimal {bankAccount}");


