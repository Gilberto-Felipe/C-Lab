// Debugging App


int[] nums = { 1, 2, 3, 4, 5 };


try
{
    Debug(nums);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}



static void Debug(int[] nums)
{
    for (int i = 0; i <= nums.Length; i++)
    {
        Console.WriteLine(nums[i]);
    }
}



//# Exepciones

//El compilador no sabe que hacer. Hay un fallo/error/excepción que no puede manejar.

//Si manejas la excepción (le dices al compilador qué hacer cuando ocurra una), entonces se convierte en una excepción manejada.

//Tu decides si manejas una excepción, si la app truena/deja de funcionar. Debes de analizar qué hacer. Depende del caso si haces una cosa u otra. 

//Si es una excepción grave, y va a afectar tu negocio, la integridad de tus datos, etc. Truena. No la manejes.

//Si la app puede continuar, sin que afecte la integridad, disponibilidad, al usuario, empresa, etc. Manéjala, muestra el mensaje de error, loguea el error para que quede evidencia y luego volver a mejorar, etc.


//## Uso de Try Catch

//Utilizas Try Catch para manejar una excepción.

//Dentro del Try va el código. Try es como un if.

//Catch es como el else, si el código falla (hay una excepción), lo atrapa para hacer algo. Los lenguajes OOP, tienen una clase Exception para manejar el error. Con el objeto ex puedes recuperar el contenido de la exepción.

//Clase exception tiene muchas propiedades. Message y TraceException son las más importantes.
//Message te dice el mensaje de error.
//TraceException... dice la clase, metodo, línea dónde ocurrió el error.


//## Uso eficiente del Try Catch

//Try Catch consume muchos recursos. Úsalo sabiamente. Planea dónde puede fallar la aplicación. Solo abraza en el try catch el código de error. No penalices la aplicación poniendo try catch a lo loco.

//El número 1 de excepciones son los datos: 1o.del usuario. 2o.de un origen de datos. Pides o llamas datos: bd, api, etc. De entrada, Pon un try catch solo alli. Si otra partes del código lo necesitan, también.

//Siempre valida datos. Siempre valida datos. Siempre valida datos. Combínalo con try Catch

//Son el 1o de los errores. 




//## Funcionamiento burbuja de las excepciónes

//Las Excepciones funcionan como burbuja. La Excepción se propaga, como burbuja, del origen a los componentes, métodos o clases superiores que usan el código que arrojo la excepción.





//## Dónde manejar la excepción cuando hay burbuja *

//Tú decides dónde manejar la excepción de acuerdo a tus necesidades.

//Generalmente, la excepción se maneja lo más cercano al usuario cuando hay una UI. Así avisas puedes avisar al usuario que hubo un error.

//El traceException te dice toda la línea de código de los métodos superiores hasta el origen.



//## Visual Studio 

//Es como un tanque lleno de posibilidades que abruman. Comienza usando lo esencial. De lo poco e importante. Luego, aprenderás las funcialidades cuando las vayas necesitando.

