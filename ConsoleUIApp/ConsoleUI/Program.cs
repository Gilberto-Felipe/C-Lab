
//try
//{
//    SimpleMethod();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//}

//Console.ReadLine();


//static void SimpleMethod()
//{
//    throw new InvalidOperationException("You should not be calling the simple method.");
//}





//Excepeciones son buena porque alertan que algo inesperado pasó y que tienes que arreglar.



/// Hay diferentes tipos de excepciones que c# ya tiene implementadas para diferentes casos de uso. Úsalas si las necesitas y quieres ser más específico.
/// 


/// Las excepciones funcionan como burbuja en una pila de memoria. 
/// El origen del error (la definicion del metodo) viene arriba de la pila. Dice donde fue el error.
/// Abajo viene el error padre, o el metodo que llama al metodo con excepcion.
/// 


/// Excepciones tienen sobre cargas, es decir diferentes opciones para elegir cual necesitas.
/// Generalmente, siempre puedes personalizar el mensaje que quieres imprimir
/// y si necesitas puedes pasar la variable ex para obtener los datos de excepcion {mensaje, traceLoop, innerException, etc. }.
/// Si no ocupas el objeto ex, no lo crees. Para que creas algo que no vas a usar.
/// 


/// En las excepciones internas de c# hay una jerarquia.
/// Las excepciones concretas son hijas, tienen menor peso.
/// La excepcion padre es la excepcion general. Esa es la que tiene mas peso.
/// 


/// Excepcion NotImplementedExceptcion
/// Es una ex que el autocompletado de codigo genera cuando vs autogenera el metodo. 
/// El metodo esta vacio. Para que no se te olvide poner codigo en el, c# pone por defecto esta Excepcion. 
/// Una vez que desarrollas el codigo deseado, elimina la excepcion.
/// 


/// Para manejar las Excepciones y que no se rompa el codigo, puedes usa un try catch 
/// Dentro del try va el codigo, es como un if
/// Si el codigo cae en una excepcion, entonces entra el catch como el else.
/// 


/// Pueden existir muchos catch despues de un try.
/// Funcionan como las ramas de un else if. Es decir, si la execpcion cae en un catch superior alli se detiene el catch. Los demas catch no se ejecutan.
/// 


/// Orden de los catch
/// Debes ser cuidadoso con el orden de los catch. El orden altera el resultado.
/// El catch general de exception va al final de los catch particulares. De lo contrario, si cae primero, como acepta todo, los demas catch particulares pierden su sentido. 
/// 


/// Filtrar un catch con when (expresion logica)
/// Filtrar ayuda a ejecutar un catch solo cuando se cae en ese caso particular
/// 
/// catch (Exception) when (name.ToLower() == "Tim") {}
/// 
/// Sirve para manejar el estado de tu aplicacion, o un proceso.


/// Finally clause
/// Es una forma de ejecutar este bloque de codigo siempre. No importa si hay un try catch, si el codigo fue ok, o cayo en una excepcion.
/// Siempre se ejecuta ese bloque finally. Siempre.
/// Sirve para ejecutar codigo que siempre quieras ejecutar. Por ejemplo, cuando quieres limpiar una conexion a db, o memoria, o algo.
/// 



/// Excepcione indican un comportamiento inesperado en tu aplicacion.
/// Si hace sentido, manejalas tu.
/// 


/// 


for (int i = 0; i < 100; i++)
{
    try
    {
        Console.WriteLine(i);

        if (i == 73)
        {
            throw new InvalidOperationException();
        }

    }
    catch (InvalidOperationException) when (i == 73) 
    { 
        throw new InvalidOperationException("73 is not a valid value for I");
    }




}




