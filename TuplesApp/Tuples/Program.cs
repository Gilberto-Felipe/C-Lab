

// MÓDULOS O FUNCIONES O MÉTODOS


/// Definición
/// Dividir el código y almacenarlo en bloques lógicos de código que realizan una tarea.
/// Esa pieza de código la puedes usar (llamar) cuantas veces sea necesario.
/// 
/// Beneficios
/// Facilita enormemente depurar el código
/// Es más legible
/// Menos errores humanos
/// concentra la lógica en un solo sitio
/// Divide el trabajo entre varios programadores
/// 
/// Contra
/// Abusar y querer usar para todo las funciones
/// Crear un chorizo de funciones anidades... Todo con medida.
/// No saber agruparlas con lógica en clases...

// Principios de disñeo de código
// DRY - no te repitas a ti mismo.
// Responsabilidad única - haz una sola cosa

/// Don't Repeat Yourself - DRY
/// No repetir la misma lógica. Centraliza en un módulo tu lógica.
/// Así tienes menos errores y es más fácil depurar el código. Encontrar errores y arreglarlos.
/// El código es más legible.
/// 

/// Responsablidad única
/// Es la S del Acrónimo SOLID.
/// Significa que un módulo debe realizar una sóla tarea, tener un sólo propósito. Puede tener muchos pasos, u otras funciones, pero realiza un objetivo. Por ejemplo, loguea un usuario, realiza una operación matemática, Imprime un mensaje en consola...
/// Meter muchas tareas en un solo módulo, no sirve. 
/// Invalida su función de divide y vencerás.
/// 


// Tuplas  

/// Sirven para regresar más de un valor o variable de un método. Es una forma más ordenada de hacerlo. 
/// Regresa más de uno, pero tampoco una multitud. Son pocos valores, 2, 3, 4, 5. Por ejemplo, quiero retornar nombre, apellido e email, pero en tres variables diferentes. Entonces, utilizo una tupla.
/// 
/// Para retornar muchos valores hay otras estructuras de datos: array, lista, objetos, etc.
/// 
/// Permiten guardar valores de diferentes tipos.
/// 
/// Modo moderno de regresar más de un valor de un método.
/// 
/// Compatibilidad
/// Las tuplas no existen en .net framework.
/// Existen desde .net Core en adelante. 
/// 

// usamos el namespace Tuples para poder usar ConsoleMessages, sin tener que escribir Tuples.ConsoleMessages.GetFullName(). Es como el Console.WriteLine, allí usamos el using System.

using Tuples;

// guardamos los valres de retorno en una variable

// si el tipo de dato de la variable es (<t>,<t>) las variables de la tupla caundo las usamos son Item1... pero no son descriptivas.
(string, string) name = ConsoleMessages.GetFullName();

Console.WriteLine($"{name.Item1} {name.Item2}");


// si queremos que las variables sean desciptivas añadimos el nombre de las variables acompañanado al tipo de dato ((<t> firstName,<t> lastName))

(string firstName, string lastName) fullName = ConsoleMessages.GetFullName();

Console.WriteLine($"{fullName.firstName} {fullName.lastName}");


// si queremos solo las variables sin el objeto tupla que las encierra, podemos extraer (destructurar) solo las de los valores de la tupla.

(string nombre, string apellido) = ConsoleMessages.GetFullName();

Console.WriteLine($"{nombre} {apellido}");



// podemos escribir menos código si usamos la palabra reservada var en lugar de (sting, string). Var es un acortador, no cambia el código...

// 


// Usar Discard _
/// Discard sirve cuando no quieres usar una variable que retorna obligatoriamente porque asi fue definida.
/// Como no te interesa el dato, para que creas la variable
/// _ no crea la variable. Dice que esa varibale y su dato, no nos interesa. Entonces, no lo crea.
/// 



// Para regresar mas de un valor de un método
/// Antes se usaba un Procemiento.
/// Un procedimiento es igual que una funcion/metodo pero retornaba mas de una variable. No solo la expresion de la funcion. El procesdimiento no esta unido a un valor o expresion. 
/// La funcion o metodo solo regresa un valor o expresion que representa el valor de la varible.
/// 
/// Por eso existe Procedimientos/metodos en funciones internas de C# en .NET Framework. Por ejemplo, 
/// int.TryParse(ageText, out int age)
/// (<el primer valor es el parametro de entrada>, <el segundo valor es el segundo parametro de salida>)
/// el primer parametro de salida es un booleano que es lo que retorna int.TryParse().
/// Como procedimiento int.TryParse() regresaba dos variables, un booleano y un int.
/// 
/// En C# ya no son necesarios los procedimientos, ahora podemos crear metodos que regresan tuplas.
/// 







