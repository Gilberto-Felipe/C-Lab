
// INTEGERS IN C#

// declaracion of integer numbers
// integers means a whole numbers, they do not have decimals.
int age = 0;

// Assign 
age = 43;

// los tipos no se cruzan
// age = "50"  NO da un error

// Use 
Console.WriteLine(age);


int ageInTenYears = 38 + 10;

Console.WriteLine(ageInTenYears);




// APUNTES


// Mejor ser especificos en las declaraciones, poner el valor por defecto. Asi todos estan en la misma linea. No se asumen cosas.
/// 


// Overload - sobrecarga
/// Un mismo método puede recibir tipos diferentes como parámetros
/// 

// Computer Science class
/// int = int32 == número entero de 32 bits
/// int puede ser signado con signo (signed) / no signado - sin signo (unsigned)
/// int32 signado +/- puede almacenar redondeando un numero de 2 millares de dígitos + o -
/// int32 no signado puede almacenar alrededor de 4 millares de dígitos
/// int32 la base es binaria, puede almacenar numeros de hasta 2^32 que dan los 2 o 4 millares de millon de digitos
/// 1 bit = 2 puede ser 0 ó 1.
/// 2 bits = 4 = 11 
/// 3 bits = 8 = 111
/// 4 bits = 16 = 1111
/// cada vez que se aumenta un bit se multiplica por el doble del anterior...
/// 8 bits = 1 byte = 00000000 = 256 digitos...
/// 32 bits = 4 millares de millon redondeando...

// int64 No ES LO DOBLE DE int32...
/// Es un chingo... casi ninguna persona en el mundo sabe el nombre de ese número
/// int64 es lo doble de int63... 
/// No existe caso de uso para int64 en aplicaciones normales... Tal vez ni Amazon...
/// 

// La teoría de los números binarios es super importante porque las computadoras calculan binarios... NO sistema decimal...
/// Compilan los números a binario...
/// no entender las bases puede llevar a terribles decisiones en una aplicación.
/// 

// unsigned y signed se basan en binario...
/// por ejemplo signed de un byte 
/// Un byte son 8 bits = 00000000
/// Utilizan el ultimo bit 0 o 1 para el signo... +/- y eso reduce el numero que se almacena a la mitad.
/// si no se usa signo, entonces se usan los 8 bits para almacenar el numero, y por eso dobla el numero de digitos.
/// 


// No dividas Int, no sirven para dividir...
/// sirven para Sumar, Restar y Multiplicar, pero No para dividir porque puede haber resultado con decimales
/// Int trunca la parte decimal. 2.5 = 2, 2.8 = 2, 1.1 = 1.
/// 







