using System;

namespace EventosTask
{
    internal partial class Program
    {
        public class Subscriptor
        {
            public string Name { get; set; }

            // Que va a hacer el subscritor cuando reciba el evento
            public void HandleEvent(object sender, EventArgs args)
            {
                Console.WriteLine("*****");
                Console.WriteLine($"{ Name } - Mensaje Recibido. Gracias!");
            }
        }
    }
}
