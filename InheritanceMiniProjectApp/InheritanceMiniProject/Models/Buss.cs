using InheritanceMiniProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Models
{
    public class Buss : Inventory, IRentable
    {
        public DateTime TravelDate { get; set; }
        public int NumberSits { get; set; }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("The bus was Rented");
        }

        public void Return()
        {
            QuantityInStock += 1;
            Console.WriteLine("The bus has been returned to inventory.");
        }
    }
}
