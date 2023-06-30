using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosTask
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var publicador = new Publicador()
            {
                Name = "EL Boss",
            };

            var subscritor = new Subscriptor()
            {
                Name = "Juanito"
            };

            var subscriptor2 = new Subscriptor()
            {
                Name = "Maria"
            };

            Console.WriteLine("Leer comunicaciones");

            // aniadir suscriptor al evento
            publicador.MyEvent += subscritor.HandleEvent;
            publicador.MyEvent += subscriptor2.HandleEvent;


            //Console.WriteLine("Removiendo un subscriptor");

            //publicador.MyEvent -= subscriptor2.HandleEvent;

            // ejecutar el metodo del publicador que invoca al evento
            publicador.EscribirMensaje("Hola mundo... Estoy aprendiendo sobre eventos en C#. Fin del mensaje.");

            Console.ReadLine();
        }
    }
}
