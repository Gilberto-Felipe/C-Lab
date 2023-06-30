using System;

namespace EventosTask
{
    internal partial class Program
    {
        public class Publicador
        {
            public string Name { get; set; }

            // Defino el delegado evento, este va a listar a los subscriptores y les va a mandar/avisar del evento
            public event EventHandler MyEvent;

            // Metodo en el que ocurre el evento
            public void EscribirMensaje(string message)
            {
                Console.WriteLine($"{Name} - {message}");

                // llamada al metodo del evento
                Publicar();

                // podria ahorrar el metodo publicar e Invocar el evento aqui mismo
                // MyEvent?.Invoke(this, EventArgs.Empty);
            }

            // Es el metodo que envuelve la llamada del evento
            protected virtual void Publicar()
            {
                MyEvent?.Invoke(this, EventArgs.Empty);

                // El ? checador de navegacion nula valida que MyEvent no sea nulo.
                // Si es nulo lanza una excepcion en tiempo de ejecucion
                // ? es el acortador para if (MyEvent != null) ...
            }
        }
    }
}
