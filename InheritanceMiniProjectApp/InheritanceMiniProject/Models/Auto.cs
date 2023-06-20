using InheritanceMiniProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Models
{
    public class Auto : Inventory, IRentable, IPurchasable
    {
        public int DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("The auto was Purchased");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("The auto was Rented");
        }

        public void Return()
        {
            QuantityInStock += 1;
            Console.WriteLine("The auto has been returned to inventory.");
        }
    }
}
