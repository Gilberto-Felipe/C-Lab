using System;

namespace InheritanceDemo
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }
        public string Motor { get; set; }
        public int CantidadPasajeros { get; set; }

        public void Arrancar()
        {
            Console.WriteLine("El verhiculo esta arrancando.");
        }
        public void Detener()
        {
            Console.WriteLine("El vehiculo se ha detenido.");
        }
    }
}
