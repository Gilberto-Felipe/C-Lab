using System;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehiculos = new List<Vehiculo> 
            { 
                new Carro(),
                new Motocicleta(),
                new Bote()
            };

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo is Carro carro)
                {
                    carro.Marca = "Audi";
                }

                if (vehiculo is Motocicleta moto)
                {
                    moto.Marca = "Harley";
                }

                if (vehiculo is Bote bote)
                {
                    bote.Marca = "Cruiser";
                }
            }

            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo);
            }

            Console.ReadLine();

        }
    }
}
